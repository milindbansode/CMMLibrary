import { NgModule } from '@angular/core';
import { from } from 'rxjs';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatListModule } from '@angular/material/list';
import { MatProgressBarModule } from '@angular/material/progress-bar';
import { MatPaginatorModule } from '@angular/material/paginator';

@NgModule
  ({
    imports: [
    ],
    exports: [
      MatGridListModule,
      MatListModule,
      MatProgressBarModule,
      MatPaginatorModule
    ],
    providers: [
    ]
  }) export class AngularMaterialModule {}

