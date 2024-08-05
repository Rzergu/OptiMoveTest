import {ChangeDetectionStrategy, Component, inject, model, signal} from '@angular/core';
import {FormsModule} from '@angular/forms';
import {MatButtonModule} from '@angular/material/button';
import {
  MAT_DIALOG_DATA,
  MatDialog,
  MatDialogActions,
  MatDialogClose,
  MatDialogContent,
  MatDialogRef,
  MatDialogTitle,
} from '@angular/material/dialog';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatInputModule} from '@angular/material/input';
import { Strategy } from '../Strategies.component';
import {NgxMaterialTimepickerModule} from 'ngx-material-timepicker';

/**
 * @title Dialog Overview
 */
@Component({
  selector: 'strategyDialog',
  templateUrl: 'stratigiesDialog.component.html',
  standalone: true,
  imports: [
    MatFormFieldModule,
    MatInputModule,
    FormsModule,
    MatButtonModule,
    MatDialogTitle,
    MatDialogContent,
    MatDialogActions,
    MatDialogClose,
    NgxMaterialTimepickerModule
  ],
  changeDetection: ChangeDetectionStrategy.OnPush,
})

export class StrategyDialog {
  readonly dialogRef = inject(MatDialogRef<StrategyDialog>);
  readonly data = inject<Strategy>(MAT_DIALOG_DATA);

  onNoClick(): void {
    this.dialogRef.close();
  }
}


/**  Copyright 2024 Google LLC. All Rights Reserved.
    Use of this source code is governed by an MIT-style license that
    can be found in the LICENSE file at https://angular.io/license */