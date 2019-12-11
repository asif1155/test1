import { Component, OnInit, ViewChild } from '@angular/core';
import { DataService } from '../model/data.service';
import { MatTableDataSource } from '@angular/material';
import { Router } from '@angular/router';
import { MatPaginator } from '@angular/material';
import { DataItem } from '../model/data-item';
import { BehaviorSubject } from 'rxjs';
//import { MatPaginator } from '@angular/material/paginator';

@Component({
  selector: 'app-all-event',
  templateUrl: './all-event.component.html',
  styleUrls: ['./all-event.component.css']
})
export class AllEventComponent implements OnInit {

  searchValue: string;
  showProgressBar: boolean = true;
  //ELEMENT_DATA: Category[];
  dataSource = new MatTableDataSource();
  //editData = new EventEmitter();
  data: DataItem = {
    id: null,
    userID: '',
    title: '',
    description: '',
    eventDate: new Date(),
    startTime: new Date(),
    endTime: new Date(),
    location: '',
    notifyBefore:30,
    label: ''
  };
  constructor(private _dataService: DataService, private router: Router, 
    private categoryCreate: DataService, 
    //private confilmDeleteDialogServiece: ConfilmDeleteDialogServiece
    ){}

  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  ngAfterViewInit(){
    //console.log("hello");
    this.dataSource.paginator = this.paginator;
  }
  ngOnInit() {
    this._dataService.getAllEvent().subscribe(data=> {
      this.dataSource.data = data;
      this.showProgressBar = false;
      //console.log(this.dataSource.data);
    });
    //console.log(this.ELEMENT_DATA);
  }
  filterData(){
    this.dataSource.filter = this.searchValue.trim().toLowerCase();
  }  
  onEdit(row){
    //console.log(row);
    //this.editData.emit(this.data);
    this.router.navigate(["/admin/manage/category/edit/"], row.id);
  }/*
  onDelete(id){
    //console.log(id);
    this.confilmDeleteDialogServiece.confilmDeleteDialog()
    .afterClosed().subscribe(data => this.deleteCategory(data, id));
  }*/
  deleteEvent(id){
    console.log(id)
    if(id>0){
      this._dataService.deleteEventById(id).subscribe((data)=>{
        this._dataService.getAllEvent().subscribe(data=> this.dataSource.data = data);
      });
    }
  }
  editData = new BehaviorSubject(this.data);
  currentData = this.editData.asObservable();
  displayedColumns: string[] = ['Title', 'Description', 
    'EventDate', 'StartTime', 
    'EndTime', 'Location', 'NotifyBefore', 
     'Action'];

}
