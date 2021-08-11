import { NgIf } from '@angular/common';
import { Component, OnInit,Output,EventEmitter } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-input-form',
  templateUrl: './input-form.component.html',
  styleUrls: ['./input-form.component.css']
})

export class InputFormComponent implements OnInit {

  isSubmitted = false;
  name = '';


  @Output() onNameAdded = new EventEmitter<string>();

  constructor() { }

  ngOnInit(): void {
  }

  Add()
  { 
    this.onNameAdded.emit(this.name);
    this.name='';
  }

  IsCheckedActive=false;
  IscheckedInactive=false;

  submitForm(form: NgForm) {
    this.isSubmitted = true;
    if(!form.valid) {
      return false;
    } else {
    alert(JSON.stringify(form.value))
    //console.log(form.value)
    }
  }

  
}
