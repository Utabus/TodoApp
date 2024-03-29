import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { PaymentDetails } from 'src/app/shared/payment-details.model';
import { PaymentDetailsService } from 'src/app/shared/payment-details.service';

@Component({
  selector: 'app-payment-details-form',
  templateUrl: './payment-details-form.component.html',
})
export class PaymentDetailsFormComponent {
  constructor(public service: PaymentDetailsService,private toastr:
    ToastrService){
  }
  onSubmit(form:NgForm){
    this.service.formSubmitted = true
    if(form.value)
    { 
       if(this.service.formData.paymentDetailId == 0)
        this.insertRecord(form)
      else
        this.updateRecord(form)

    }
  
  }

  insertRecord(form:NgForm){
    this.service.postPaymentDetail()
    .subscribe({
      next: res=> {
       this.service.list = res as PaymentDetails[]
       this.service.resetForm(form)
        this.toastr.success('Inserted successfully' ,
        'Payment Detail Register')
      },
      error: err=>{console.log(err)}
    })
  }
   updateRecord(form:NgForm){
    this.service.putPaymentDetail()
    .subscribe({
      next: res=> {
       this.service.list = res as PaymentDetails[]
       this.service.resetForm(form)
        this.toastr.info('Update successfully' ,
        'Payment Detail Register')
      },
      error: err=>{console.log(err)}
    })
  }

}
