import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';

export class AuthorData {
  id: string;
  name: string;
  bookName: string;
}

@Component({
  selector: 'app-authors',
  templateUrl: './authors.component.html',
  styleUrls: ['./authors.component.css']
})
export class AuthorsComponent implements OnInit {

  displayedColumns: string[] = ['id', 'authorname', 'bookname'];
  dataSource: any;


  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort: MatSort;

  constructor() {
    var authorData: any;

    authorData =
      [
        {
          id: 1,
          authorname: 'chk1',
          bookname: 'test book name'
      },
      {
        id: 2,
        authorname: 'chk2',
        bookname: 'test2 book name'
      }
      ];
      

    this.dataSource = authorData;

  }

  ngOnInit() {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;

  } 



}
