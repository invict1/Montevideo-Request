import { Type } from './../../../../models/type';
import { AlertComponent } from 'ngx-bootstrap/alert/alert.component';
import { Component, OnInit } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { TypeService } from '../../../../services/type.service';

@Component({
  selector: 'app-edit-type',
  templateUrl: './edit-type.component.html',
  styleUrls: ['./edit-type.component.css']
})
export class EditTypeComponent implements OnInit {
  type: Type;
  closeBtnName: string;
  editForm: FormGroup;
  submitted = false;
  error = false;
  errorMessage = '';
  constructor(public bsModalRef: BsModalRef, private typeService: TypeService, private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.editForm = this.formBuilder.group({
      name: ['', Validators.compose([Validators.required, Validators.pattern('^[a-zA-Z ]*$')])]
    });
  }

  get t() { return this.editForm.controls; }

  public submit() {
    this.submitted = true;
    if (this.editForm.invalid) {
      return;
    }
    this.typeService.edit(this.type).subscribe(
      () => {
        this.bsModalRef.hide();
      },
      ((error: any) => {
        this.errorMessage = error;
        this.error = true;
      })
    );
  }

  onClosed(): void {
  // onClosed(dismissedAlert: AlertComponent): void {
    this.error = false;
  }

}
