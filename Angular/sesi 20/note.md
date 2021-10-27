============================================================================
SESSION 20: ANGULAR LIFECYCLES
============================================================================

Angular memiliki beberapa lifecycle, dengan urutan sebagai berikut:

- constructor -> bukan lifecycle sebenarnya, tapi akan dijalankan setiap kali
                 instance baru dibuat

- ngOnChanges -> akan dijalankan setiap kali perubahan dideteksi oleh Angular

- ngOnInit    -> akan dijalankan sekali, khususnya setelah component berhasil
                 dibentuk pertama kalinya.

- ngDoCheck   -> akan dijalankan setiap kali perubahan terjadi, dan tidak
                 dapat dideteksi oleh Angular. Perlu diingat, hook ini akan
                 di-trigger setiap perubahan terjadi.

-- Lifecycle berikut hanya terjadi untuk child component
[bayangkan ini dengan hooks created pada Vue jika kalian pernah membuat
aplikasi dengan Vue]
- ngAfterComponentInit    -> hanya terjadi sekali, yaitu ketika child component
                             berhasil dibuat, dan data berhasil diteruskan ke
                             dalam child component
- ngAfterComponentChecked -> terjadi setelah adanya perubahan pada child
                             component. Perlu diingat, sama seperti ngDoCheck,
                             hook ini akan di-trigger setiap perubahan terjadi.

[bayangkan ini dengan hooks mounted pada Vue jika kalian pernah membuat
aplikasi dengan Vue]
- ngAfterViewInit    -> hanya terjadi sekali, yaitu ketika child component
                        berhasil di-mount ke dalam DOM
- ngAfterViewChecked -> terjadi setelah adanya perubahan pada child component.
												Perlu diingat, sama seperti ngDoCheck, hook ini akan
                        di-trigger setiap perubahan terjadi.

============================================================================
SESSION 20: ANGULAR DATA BINDING
============================================================================

## Apa itu Angular Data Binding?

Data Binding di Angular akan memungkinkan kita untuk membuat halaman ter-
update secara otomatis berdasarkan state aplikasi tersebut.

## Tipe dan Target data binding

Angular memiliki beberapa macam untuk mengikat suatu prop/attribute dengan
sebuah data/event:

- Property
  Data akan di-bind ke property secara langsung, ataupun ke dalam attribute
  HTML yang ada. Sintaksnya adalah `[]`. Contohnya:
  - Element property
  	[src]="data"
  - Component property
  	[heroes]="data"
  - Directive property
  	[ngClass]="{ 'bg-red-400': !isValid }"

- Event
  Event akan di-bind untuk melemparkan suatu data dari satu component ke
  component lainnya. Sintaksnya adalah `()`. Contohnya:
  - Element event
  	<button (click)="functionName()">Click me</button>
  - Component event
  	<app-component (deleteRequest)="functionName()"></app-component>
  - Directive event
  	<div (customClickEvent)="clicked=$event" clickable>Click me</div>

- Two-way binding
  Ini hanya berlaku pada directive `ngModel`, yang nantinya akan di-bind
  ke sebuah property pada component tersebut.

  ```ts
  // input.component.ts

  // @Component({ ... })
  class InputComponent {
    propertyName = ''
  }
  ```

  ```html
  <!-- input.component.html -->
  <input ([ngModel])="propertyName" />
  ```

- Attribute
  Ini lebih sering digunakan pada `aria-` dan `data-`. Untuk dapat masuk
  kepada `aria-` dan `data-`, kita bisa tambahkan `attr` seperti cara di
  bawah ini:
  ```html
  <button [attr.aria-label]="help">Help me!</button>
  ```

- Class
  Ini sama seperti kita pakai directive `ngClass`, hanya saja kita langsung
  define di attribute `class` seperti berikut:
  ```html
  <div [class.special]="isSpecial">Ini adalah div special</div>
  ```

- Style
  Ini akan memberikan custom inline styling ke dalam component HTML yang
  kita buat. Diawali dengan `style`, kemudian diikuti dengan nama styling
  yang ingin kita buat, misalkan `font-size`:
  ```html
  <div [style['font-size']]="'72px'">Teks Besar</div>
  ```

## Macam-macam data binding

- Interpolation, Property, Attribute, Style, Class
  Yang berlaku di sini hanyalah **one-way data binding** dari Parent ke **Child**.
  Contoh:
  ```
  <!-- Interpolation -->
  {{ message }}

  <!-- data-binding di HTML -->
  <div [target]="expression"></div>
  <div bind-target="expression"></div>
  ```

- Event
  Yang berlaku di sini hanyalah **one-way data binding** dari **Child** ke Parent.
  Contoh:
  ```
  <div (event)="functionName()"></div>
  <div on-event="functionName()"></div>
  ```

- Two-way
  Sesuai namanya, memungkinkan kita untuk menggunakan **two-way data binding** antara
  Parent dan **Child** component.
  Contoh:
  ```
  <div [(target)]="expression"></div>
  <div bindon-target="expression"></div>
  ```

## EventEmitter

`EventEmitter` memungkinkan kita untuk melempar data dari Child component
kepada Parent component. `EventEmitter` ini menggunakan decorator `@Output()`
untuk meng-emit sebuah event, baik itu secara sync maupun async.

Cara ini sudah kita terapkan pada sesi 19 tentang `Angular Component` ya...

```ts
// child.component.ts
import { /* ... */ EventEmitter, Output } from '@angular/core';

// @Component({ ... })
export class ChildComponent {
  @Output() eventType = new EventEmitter(); // jika tidak ada value yang dilempar
  @Output() anotherEventType = new EventEmitter<number | string /* | dataTypeLain */>(); // jika tidak ada value yang dilempar

  eventHandler () {
    this.eventType.emit();
  }

  anotherEventHandler (value: number | string /* | dataTypeLain */) {
    this.anotherEventType.emit(value);
  }
}
```
### Error 
TS2322: Type 'Event' is not assignable to type 'string'. .

### Solved
https://stackoverflow.com/questions/66407703/error-ts2322-type-event-is-not-assignable-to-type-string-ngmodel-todo/67817027#67817027
