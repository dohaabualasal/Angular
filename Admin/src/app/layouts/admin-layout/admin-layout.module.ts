import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AdminLayoutRoutes } from './admin-layout.routing';
import { DashboardComponent } from '../../dashboard/dashboard.component';
import { UserProfileComponent } from '../../user-profile/user-profile.component';
import { TableListComponent } from '../../table-list/table-list.component';
import { TypographyComponent } from '../../typography/typography.component';
import { IconsComponent } from '../../icons/icons.component';
import { MapsComponent } from '../../maps/maps.component';
import { NotificationsComponent } from '../../notifications/notifications.component';
import { UpgradeComponent } from '../../upgrade/upgrade.component';
import {MatButtonModule} from '@angular/material/button';
import {MatInputModule} from '@angular/material/input';
import {MatRippleModule} from '@angular/material/core';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatTooltipModule} from '@angular/material/tooltip';
import {MatSelectModule} from '@angular/material/select';
import { ClinicComponent } from 'app/All-CRUD/Add-Edit-Clinic/Clinic.component';
import { ListClinicComponent } from 'app/All-CRUD/list-clinic/list-clinic.component';
import { AddEditDoctorsComponent } from 'app/All-CRUD/Add-Edit-Doctors/Add-Edit-Doctors.component';
import { AddEditOfferComponent } from 'app/Offer/add-edit-offer/add-edit-offer.component';
import { ListOfferComponent } from 'app/Offer/list-offer/list-offer.component';
import { DateFilterPipe } from 'app/pips/dateFilter.pipe';
import { FilterPipe } from 'app/pips/filter.pipe';
import { SortPipe } from 'app/pips/sort.pipe';
import { Datefilter2Pipe } from 'app/table-list/datefilter2.pipe';
import { Sort2Pipe } from 'app/table-list/sort2.pipe';

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(AdminLayoutRoutes),
    FormsModule,
    ReactiveFormsModule,
    MatButtonModule,
    MatRippleModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    MatTooltipModule,
  ],
  declarations: [
    DashboardComponent,
    UserProfileComponent,
    TableListComponent,
    TypographyComponent,
    IconsComponent,
    MapsComponent,
    NotificationsComponent,
    UpgradeComponent,
    ListClinicComponent,
    ClinicComponent,
    AddEditOfferComponent,
    Datefilter2Pipe,
    Sort2Pipe



  ]
})

export class AdminLayoutModule {}
