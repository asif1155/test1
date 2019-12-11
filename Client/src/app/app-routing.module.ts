import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { RegistrationComponent } from './registration/registration.component';
import { LoginComponent } from './login/login.component';
import { AllEventComponent } from './all-event/all-event.component';
import { AuEventComponent } from './au-event/au-event.component';

const routes: Routes = [
  {path:'Registration', component: RegistrationComponent},
  {path:'Login',        component: LoginComponent},
  {path:'AllEvent',     component: AllEventComponent},
  {path:'AuEvent',      component: AuEventComponent},
  {path:'**',           component: RegistrationComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
