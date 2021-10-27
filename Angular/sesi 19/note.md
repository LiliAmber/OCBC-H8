# Share: Angular sesi 19

1. install angular CLI -> npm install -g @angular/cli
2. ng new <NAMA_PROJECT>
   - routing? no
   - stylesheet? css
3. struktur:
   - src           --> source code project
     - app          -> semua components/service/modules/etc.
       - app.module    -> AppModule 
     - assets       ->
     - environments ->
     - index.html   ->
     - main.ts      -> 
   - node_modules  --> module yang ter-install lewat NPM
   - angular.json  --> konfigurasi angular
   - karma.conf.js --> unit testing
   - tsconfig.json --> konfigurasi typescript


============================================================================
SESSION 20: ANGULAR COMPONENTS
============================================================================

#### Membuat Component Baru

1. Dengan CLI
   - Jalankan `ng g component <NAMA_COMPONENT>`

2. Manual
  - Buat file HTML, TS (khusus component utama), dan CSS, dengan struktur nama:
    `<NAMA_COMPONENT>.component.<EXT>`
  - Pada file TS, buat struktur berikut:
    ```ts
    import { Component } from '@angular/core';

    @Component({
      selector: '<NAMA_SELECTOR>',
      templateUrl: './<NAMA_COMPONENT>.component.html',
      styleUrls: ['./<NAMA_COMPONENT>.component.css']
    })
    export class <NAMA_COMPONENT>Component {
      constructor() {}
    }
    ```
  - Pada HTML, buat struktur HTML biasa:
    ```html
    <p><NAMA_COMPONENT> bisa jalan!</p>
		```
  - Di file `app.module.ts`, import dan tambahkan file TS-nya:
    ```ts
    import {} from './<NAMA_COMPONENT>/<NAMA_COMPONENT>.component.ts';

    // ...
    @Component({

    })
    ```

#### Lempar data antara Parent dengan Child component

Kita bisa manfaatkan `@Input` dan `@Output` untuk meneruskan data apa saja yang
ingin kita share di antara kedua component.

Beda antara keduanya apa?
- `@Input` -> kita share data yang dikirim oleh parent component ke dalam child
component. Dalam contoh di atas, dari `AppComponent` ke `ButtonComponent`
- `@Output` -> kebalikan dari `@Input`, di mana kita share data yang dikirim
oleh child component ke dalam parent component.

##### Menggunakan `@Input` untuk share data: Parent -> Child

1. tambahkan satu property baru di class `AppComponent` (file:
`app.component.ts`) seperti berikut:
```ts
// app.component.ts

// ...
export class AppComponent {
  message = "Hi! I'm your parent."
}
```
2. Lakukan property binding dengan menggunakan attribute `message` yang
dibungkus dengan `[]` (kurung siku). Kemudian berikan value berupa nama property
yang sudah kita buat sebelumnya, pada tag HTML `<app-button>`, seperti contoh
berikut:
```html
<app-button [message]="message"></app-button>
```
3. Pindah ke file `button` component, kita buat property seperti langkah 1
sebelumnya. Namun, kali ini kita tambahkan `@Input` di depan nama property kita,
pada `ButtonComponent` (file: `button.component.ts`). Contoh:
```ts
// button.component.ts

// ...
export class ButtonComponent {
  @Input() message = "";
}
```
4. Setelah itu, kita render property yang kita buat tadi di file HTML
`button.component` kita. Kita gunakan kurung kumis ganda `{{}}` (disebut juga
dengan sintaks interpolation binding Angular), dengan nama property yang kita
buat sebelumnya, di dalamnya:
```html
<p>button works!</p>
<p>Incoming message: {{ message }}</p>
```

##### Menggunakan `@Output` untuk share data: Child -> Parent

Kita bisa meng-`emit` pesan yang dikirimkan oleh child component kepada parent
component di dalam Angular, dengan menggunakan directive `@Output`. Caranya
bisa kita ikuti dengan langkah berikut.

**Child Component**

1. Pada component HTML, siapkan sebuah tombol untuk melakukan trigger event.
```html
<!-- button.component.html -->
<button>Hit me</button>
```

2. Dengan tombol ini, kita bisa tambahkan sebuah event listener. Dalam hal ini,
event click kita gunakan. Untuk menambahkan event listener, kita bisa gunakan
tanda `()` (kurung biasa), yang di dalamnya kita bisa isi dengan event yang
kita inginkan -- dalam hal ini, `click`. Pada contoh ini, kita gunakan function
`sendMessage` yang tidak memerlukan parameter apapun, namun kalian bisa
tambahkan parameter di sini.
```html
<!-- button.component.html -->
<button (click)="sendMessage()">Hit me</button>
```

3. Kemudian, pada class component, tambahkan sebuah function untuk meng-handle
event yang sudah kita buat.
```ts
import {
  // ...,
  EventEmitter, // pastikan ini ter-import dari @angular/core!
  Output,       // pastikan ini ter-import dari @angular/core!
  // ...
} from '@angular/core'

@Component({
  // ...
})
class ButtonComponent {
  // 1 - tambahkan directive @Output di sini
  @Output() sendMessageEvent = new EventEmitter<string>()

  // 2 - buat event handler-nya
  sendMessage () {
    this.sendMessageEvent.emit("Hi, parent! I'm your child.")
  }
}
```

**Parent Component**

Kita juga harus membuat sebuah event listener pada parent component, agar parent
component tahu, kalau child component meng-`emit` sebuah event.

1. Pada component HTML, buatlah sebuah event listener dengan nama yang sesuai
dengan nama event yang kita buat dengan directive `@Output` di atas. Namun, kali
ini kita masukkan parameter `$event` di dalamnya. Kali ini kita namakan
`showMessage` sebagai event handler-nya.
```html
<!-- app.component.html -->
<app-button (sendMessageEvent)="showMessage($event)"></app-button>

<!-- tampilkan juga pesan yang akan kita tampilkan dengan variable message -->
<p>{{ message }}</p>
```

2. Lalu, pada class component, kita buat sebuah event handler function untuk
menampilkan pesan.
```ts
// import ...

@Component({
  // ...
})
class AppComponent {
  message = ''

  showMessage (message: string) {
    this.message = message
  }

  // ...
}
```

Jadi, pada saat kita klik tombol ini, pesan akan muncul di layar.