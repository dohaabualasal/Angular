import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { Routes, RouterModule } from "@angular/router";
import { TabsModule } from "ngx-bootstrap/tabs";

// import { AppRoutingModule } from './app-routing.module';
import { ButtonsModule } from "ngx-bootstrap/buttons";
import { BsDatepickerModule } from "ngx-bootstrap/datepicker";
import { NgxGalleryOptions } from "@kolkov/ngx-gallery";
import { NgxGalleryImage } from "@kolkov/ngx-gallery";
import { NgxGalleryAnimation } from "@kolkov/ngx-gallery";
import { AppComponent } from "./app.component";
// import { RatingModule, StarRatingComponent } from 'ng-starrating';
import {} from "./property/star-rating/star-rating.component";
import { PaginationModule } from "ngx-bootstrap/pagination";
import { NavBarComponent } from "./nav-bar/nav-bar.component";
import { PropertyCardComponent } from "./property/property-card/property-card.component";
import { PropertyListComponent } from "./property/property-list/property-list.component";
import { HttpClient, HttpClientModule } from "@angular/common/http";
import { HousingService } from "./services/housing.service";
import { PropertyDetailComponent } from "./property/property-detail/property-detail.component";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { UserServiceService } from "./services/userService.service";
import Swal from "sweetalert2/dist/sweetalert2.js";
import { BsDropdownModule } from "ngx-bootstrap/dropdown";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import {} from "@angular/animations";
import { AutherizationServiceService } from "./services/AuthrizationService";
import { PropertyDetailResolverService } from "./services/property-detail-resolver.service";
import { NgxGalleryModule } from "@kolkov/ngx-gallery";
import { FilterPipe } from "./pips/filter.pipe";
import { SortPipe } from "./pips/sort.pipe";
import { HttpClientInMemoryWebApiModule } from "angular-in-memory-web-api";
// import { SharedService } from './shared.service';
import { DoctorsInclinicService } from "./services/DoctorsInclinic.service";
import { from } from "rxjs";
// import { MatSliderModule } from '@angular/material/slider';
// import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal/public_api';
import { AddEditClinicService } from "./services/add-edit-clinic.service";
// import { ClinicComponent } from './All-CRUD/Add-Edit-Clinic/Clinic.component';
import { ClinicServiceService } from "./services/ClinicService.service";
import { ToastContainerModule, ToastrModule, ToastrService } from "ngx-toastr";
import { ScedualComponent } from "./property/Scedual/Scedual.component";
import { DoctorsService } from "./services/Doctors.service";
import { DateFilterPipe } from "./pips/dateFilter.pipe";
import { PetComponent } from "./All-CRUD/Pets/Pet/pet.component";
import { PetService } from "./services/pet.service";
import * as _ from "lodash";
import { OfferService } from "./services/Offer.service";
import { ScedualService } from "./services/Scedual.service";

import { ComponentsModule } from "./components/components.module";

import { Component, OnInit, Input, ViewChild } from "@angular/core";
import { DashboardComponent } from "./dashboard/dashboard.component";
import { UserProfileComponent } from "./user-profile/user-profile.component";
import { TableListComponent } from "./table-list/table-list.component";
import { TypographyComponent } from "./typography/typography.component";
import { IconsComponent } from "./icons/icons.component";
import { MapsComponent } from "./maps/maps.component";
import { NotificationsComponent } from "./notifications/notifications.component";
import { UpgradeComponent } from "./upgrade/upgrade.component";
import { AgmCoreModule } from "@agm/core";

import { AdminLayoutComponent } from "./layouts/admin-layout/admin-layout.component";
import { RoutingModule } from "angular-routing";
import { AppRoutingModule } from "./app.routing";
import { ClinicComponent } from "./All-CRUD/Add-Edit-Clinic/Clinic.component";
import { PetListComponent } from "./All-CRUD/Pets/pet-list/pet-list.component";
import { AppClinicComponent } from "./All-CRUD/app-clinic/app-clinic.component";
import { AddEditDoctorsComponent } from "./All-CRUD/Add-Edit-Doctors/Add-Edit-Doctors.component";
import { UserLoginComponent } from "./user/user-login/user-login.component";
import { ReservationComponent } from "./All-CRUD/Reservation/Reservation.component";
import { UserRegisterComponent } from "./user/user-register/user-register.component";
import { CustomerPageComponent } from "./CustomerPage/CustomerPage.component";
import { ListClinicComponent } from "./All-CRUD/list-clinic/list-clinic.component";
import { AddEditOfferComponent } from "./Offer/add-edit-offer/add-edit-offer.component";
import { EditOfferComponent } from "./Offer/EditOffer/EditOffer.component";
import { ListOfferComponent } from "./Offer/list-offer/list-offer.component";
import { AdminNavComponent } from "./admin-nav/admin-nav.component";
import { OverlayModule } from "@angular/cdk/overlay";
import { PortalModule } from "@angular/cdk/portal";
import { MatButtonModule } from "@angular/material/button";
import { MatRippleModule } from "@angular/material/core";
import { MatFormFieldModule } from "@angular/material/form-field";
import { MatInputModule } from "@angular/material/input";
import { MatSelectModule } from "@angular/material/select";
import { CommonModule } from '@angular/common';
import { CdkTreeModule } from '@angular/cdk/tree';
import { MatAutocompleteModule } from '@angular/material/autocomplete';
import { MatButtonToggleModule } from '@angular/material/button-toggle';
import { MatCardModule } from '@angular/material/card';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatChipsModule } from '@angular/material/chips';
import { MatDividerModule } from '@angular/material/divider';
import { MatExpansionModule } from '@angular/material/expansion';
import { MatIconModule } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
import { MatMenuModule } from '@angular/material/menu';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { MatSortModule } from '@angular/material/sort';
import { MatTableModule } from '@angular/material/table';
import { MatTabsModule } from '@angular/material/tabs';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatTreeModule } from '@angular/material/tree';
import { MatBadgeModule } from '@angular/material/badge';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatRadioModule } from '@angular/material/radio';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatTooltipModule } from '@angular/material/tooltip';
import { AboutUsComponent } from './AboutUs/AboutUs.component';
import { HomePageComponent } from './HomePage/HomePage.component';
import { FooterComponent } from './footer/footer.component';
import { AdminLoginComponent } from "./user/Admin-login/Admin-login.component";
import { AdminRegisterComponent } from "./user/Admin-Register/Admin-Register.component";
const appRoutes: Routes = [
  { path: "", component: PropertyListComponent },
  { path: "Clinic", component: PropertyListComponent },
  { path: "home", component: HomePageComponent },


  { path: "testomonial", component: CustomerPageComponent },
  { path: "Scedual/:Id", component: ScedualComponent },
  { path: "Add-Offer", component: AddEditOfferComponent },
  { path: "List-Pet/:Id", component: PetListComponent },
  { path: "Add-Doctor/:id", component: AddEditDoctorsComponent },
  { path: "Add-Pet/:Id", component: PetComponent },
  { path: "List-Offer", component: ListOfferComponent },
  { path: "AboutUs", component: AboutUsComponent },

  { path: "Pet", component: PetComponent },
  { path: "Edit-Offer", component: EditOfferComponent },

  {
    path: "property-detail/:Id",
    component: PropertyDetailComponent,
    resolve: { PropertyDetailResolverService },
  },
  { path: "login", component: UserLoginComponent },
  { path: "Adminlogin", component: AdminLoginComponent },

 { path: "Adminregister", component: AdminRegisterComponent },
  { path: "Reservation/:Id", component: ReservationComponent },
  { path: "register", component: UserRegisterComponent },

  { path: "**", component: PropertyListComponent },
];
const materialModules = [
  CdkTreeModule,
  MatAutocompleteModule,
  MatButtonModule,
  MatCardModule,
  MatCheckboxModule,
  MatChipsModule,
  MatDividerModule,
  MatExpansionModule,
  MatIconModule,
  MatInputModule,
  MatListModule,
  MatMenuModule,
  MatProgressSpinnerModule,
  MatPaginatorModule,
  MatRippleModule,
  MatSelectModule,
  MatSidenavModule,
  MatSnackBarModule,
  MatSortModule,
  MatTableModule,
  MatTabsModule,
  MatToolbarModule,
  MatFormFieldModule,
  MatButtonToggleModule,
  MatTreeModule,
  OverlayModule,
  PortalModule,
  MatBadgeModule,
  MatGridListModule,
  MatRadioModule,
  MatDatepickerModule,
  MatTooltipModule
];
@NgModule({
  imports: [
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    ComponentsModule,
    RouterModule,
    AppRoutingModule,
    AgmCoreModule.forRoot({
      // tslint:disable-next-line: quotemark
      apiKey: "YOUR_GOOGLE_MAPS_API_KEY",
    }),
    RoutingModule.forRoot(),
    BrowserAnimationsModule,
    /// CountdownTimerModule.forRoot(),
    // required animations module
    ToastrModule.forRoot(), // ToastrModule added
    ToastrModule.forRoot({
      timeOut: 10000,
      positionClass: "toast-bottom-right",
      preventDuplicates: true,
    }),
    
    
    ToastrModule.forRoot({ positionClass: "inline" }),
    ToastContainerModule,
    PaginationModule.forRoot(),
    BrowserAnimationsModule,
    BsDropdownModule.forRoot(),
    TabsModule.forRoot(),
    ButtonsModule.forRoot(),
    NgxGalleryModule,
    RouterModule.forRoot(appRoutes),
    materialModules,
   


  ],
  declarations: [			
    AppClinicComponent,
    AppComponent,
    AdminLayoutComponent,
    NavBarComponent,
    PropertyListComponent,
    
    AppClinicComponent,

    ScedualComponent,
    UserLoginComponent,
    UserRegisterComponent,
    ReservationComponent,
    CustomerPageComponent,
    PetComponent,
    PetListComponent,

    EditOfferComponent,

    ListOfferComponent,
    FilterPipe,
    SortPipe,
    DateFilterPipe,

    AppClinicComponent,

    ReservationComponent,
    CustomerPageComponent,
    AdminNavComponent,
    AddEditDoctorsComponent,
    NavBarComponent,
    PropertyDetailComponent,
  PropertyListComponent,
      AboutUsComponent,
      HomePageComponent,
      FooterComponent,
      AdminLoginComponent,
      AdminRegisterComponent
   ],
  providers: [
    HousingService,
    UserServiceService,
    AutherizationServiceService,
    PropertyDetailResolverService,

    DoctorsInclinicService,
    AddEditClinicService,
    ClinicServiceService,
    DoctorsService,
    PetService,
    OfferService,
    DoctorsService,
    ScedualService,
    PetComponent,
    AddEditDoctorsComponent,
    ToastrService,
  ],
  bootstrap: [AppComponent],
  exports: [
    materialModules
  ],
 
})
export class AppModule {}
