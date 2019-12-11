import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {

  regForm: FormGroup;

  constructor() { 
    this.regForm = new FormGroup({
      name: new FormControl('', [Validators.required]),
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required]),
      birthday: new FormControl('', [Validators.required]),
    });
  }

  onSubmit(){
    console.log(this.regForm.value);
  }

  ngOnInit() {
  }

}
