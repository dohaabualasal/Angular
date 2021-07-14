import { Injectable } from '@angular/core';
import {
  ActivatedRoute,
  ActivatedRouteSnapshot,
  Resolve,
  RouterStateSnapshot,
} from '@angular/router';
import { Observable } from 'rxjs';
import { Property } from '../model/Property';
import { HousingService } from './housing.service';

@Injectable({
  providedIn: 'root',
})
export class PropertyDetailResolverService implements Resolve<Property> {
  constructor(private housingService: HousingService) {}
  resolve(
    rout: ActivatedRouteSnapshot,
    state: RouterStateSnapshot
  ): Observable<Property> | Property {
    const propId = rout.params['Id'];
    return this.housingService.getProperty(propId)as any ;
  }
}
