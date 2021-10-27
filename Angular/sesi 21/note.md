===========================================================================
SESSION 21: ANGULAR DIRECTIVES
============================================================================

### Structural Directives

1. ngIf
2. ngFor
3. ngSwitch

> Kita harus memberikan tanda `*` sebelum salah satu dari directive di atas
> Contoh: `*ngIf`, `*ngFor`, `*ngSwitch`

#### ngIf

```html
<p *ngIf="isShown">You found this paragraph.</p>
```

- cek property `isShown` yang ada di component
- kalau property `isShown` bernilai falsy, maka paragraf di atas tidak tampil
- kalau property bernilai truthy, maka paragrafnya muncul