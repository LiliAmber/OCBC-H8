import { ComponentFixture, TestBed } from '@angular/core/testing';
import { LoginFormComponent } from './login-form.component';
import {ReactiveFormsModule} from '@angular/forms'

describe('LoginFormComponent', () => {

  const validUser = {
    email: 'user@mail.com',
    password: 'abc123'
  }

  let component: LoginFormComponent;
  let fixture: ComponentFixture<LoginFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ReactiveFormsModule],
      declarations: [ LoginFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LoginFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should render email and password input elements', () => {
    const compiled = fixture.debugElement.nativeElement
    // const  formElement = compiled.querySelector('#loginForm')
    const emailInputElement = compiled.querySelector('input[id="email"]')
    const passInputElement = compiled.querySelector('input[id="password"]')

    expect(emailInputElement).toBeTruthy()
    expect(passInputElement).toBeTruthy()
  })

  it('check initial value of login form group', () => {
    const loginFormGroup = component.loginForm
    const loginFormValue = {
      email: '',
      password: ''
    }

    expect(loginFormGroup.value).toEqual(loginFormValue)
  })

  it('validate email input: `required, mingLength(5), email type`', () => {
    const email = component.email

    email?.setValue('')
    expect(email?.hasError('required')).toBeTruthy()

    email?.setValue('abcd')
    expect(email?.hasError('minlength')).toBeTruthy()

    email?.setValue('abcdefghij')
    expect(email?.hasError('email')).toBeTruthy()
  })

  it('should have invalid form when empty', () => {
    const email = component.email
    const password = component.password

    email?.setValue('')
    password?.setValue('')
    expect(component.loginForm.valid).toBeFalsy()
  })

  it('should check validity when validators are fullfilled', () => {
    const compiled = fixture.debugElement.nativeElement
    const emailInputElement = compiled.querySelector('input[id="email"]')
    const passInputElement = compiled.querySelector('input[id="password"]')

    if(!!emailInputElement && !!passInputElement) {
      emailInputElement.value = validUser.email
      emailInputElement.dispatchEvent(new Event('input'))

      passInputElement.value = validUser.password
      passInputElement.dispatchEvent(new Event('input'))
    }

    expect(component.loginForm.valid).toBeTruthy()
  })

  it('should submitting form and set current user', () => {
    const compiled = fixture.debugElement.nativeElement
    const emailInputElement = compiled.querySelector('input[id="email"]')
    const passInputElement = compiled.querySelector('input[id="password"]')

    if(!!emailInputElement && !!passInputElement) {
      emailInputElement.value = validUser.email
      emailInputElement.dispatchEvent(new Event('input'))

      passInputElement.value = validUser.password
      passInputElement.dispatchEvent(new Event('input'))

      fixture.detectChanges()
    }

    const button = compiled.querySelector('button')
    button.click()

    expect(component.currentUser.email).toEqual(validUser.email)
    expect(component.currentUser.isLogin).toBeTruthy()
  })
});
