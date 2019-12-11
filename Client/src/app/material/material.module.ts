import { NgModule } from '@angular/core';
import {MatButtonModule, MatTableModule, MatIconModule, MatDialogModule, 
  MatProgressBarModule, MatCardModule, MatGridListModule, MatSelectModule, 
  MatToolbarModule, MatSidenavModule, MatRippleModule, MatExpansionModule, 
  MatTableDataSource} from '@angular/material';
import {MatInputModule} from '@angular/material/input';

const MaterialComponents = [
  MatButtonModule,
  MatInputModule,
  MatTableModule,
  MatIconModule,
  MatDialogModule,
  MatProgressBarModule,
  MatCardModule,
  MatGridListModule,
  MatSelectModule,
  MatToolbarModule,
  MatSidenavModule,
  MatRippleModule,
  MatExpansionModule //,
  //MatTableDataSource 
];

@NgModule({
  imports: [MaterialComponents],
  exports: [MaterialComponents]
})
export class MaterialModule { }
