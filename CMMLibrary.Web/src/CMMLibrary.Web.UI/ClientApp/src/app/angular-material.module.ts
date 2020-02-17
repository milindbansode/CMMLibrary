import { NgModule } from '@angular/core';
import { AuthorsComponent } from './authors/authors.component';

import { MatGridListModule } from '@angular/material/grid-list';
import { MatListModule } from '@angular/material/list';
import { MatProgressBarModule } from '@angular/material/progress-bar';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatTableModule } from '@angular/material/table';

@NgModule({
  exports: [
    MatGridListModule
    , MatListModule
    , MatProgressBarModule
    , MatPaginatorModule
    , MatTableModule
  ],

  declarations: [],
  imports:
    [
    
  ],
  bootstrap: []
})
export class AngularMaterialModule { }
