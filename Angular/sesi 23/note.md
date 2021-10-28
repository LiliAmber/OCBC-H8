### module & view encapsulation in angular

example to generate new module: 
```ts
    ng generate module CustomerDashboard 
```

example to generate new component in module:
1. masuk ke direktori modul
2. run this command in terminal
```ts
    ng generate component customer-dashboard/CustomerDashboard
```

encapsulation example: 
https://stackblitz.com/angular/lyeqqlrdybb?file=src%2Fapp%2Fapp.component.ts

shadow dom :
https://developer.mozilla.org/en-US/docs/Web/Web_Components/Using_shadow_DOM

note:
Shadow dom bisa override anaknya kecuali yang encapsulated
jadi kalau pakai Shadow bisa override si child kecuali yang emulated
kalau kita pakai Encap di luar si child engga ke override sama Encap tidak bisa di override lagi
kalau engga import ViewEncapsulation itu kata mas eas kita udah pake emulated
jadi css kita tidak dapat ditimpa lagi, yg emulated jdi defaultnya
jadi Emulated mah terisolasi dari override maupun nge override