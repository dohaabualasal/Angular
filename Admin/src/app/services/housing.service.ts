import { Injectable } from '@angular/core';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { analyzeAndValidateNgModules } from '@angular/compiler';
import { IProperty } from '../property/IProperty.Interface';
import { Observable } from 'rxjs';
import { Property } from '../model/Property';

@Injectable({
  providedIn: 'root',
})
export class HousingService {

  constructor(private http: HttpClient) {}
  getProperty(id: number) {
    return this.GetAllProperties().pipe(
      map(propertiesArray => {
        
        return propertiesArray.find(p => p.Id === id);
      })
    );
  }
  GetAllClinic ():Observable<string[]>
  {
       return this.http.get<any[]>('http://localhost:5000/api/Clinic');
  }
  GetAllProperties(): Observable<IProperty[]> {
    return this.http.get<any[]>('http://localhost:5000/api/Clinic').pipe(
      map((data: any) => {


        const localProperties = JSON.parse(String(localStorage.getItem('newProp')));

        const propertiesArray: Array<IProperty> = [];
        if (localProperties) {
          for (const id in localProperties) {
            if (localProperties.hasOwnProperty(id) )
             {
              propertiesArray.push(localProperties[id]);
            }
          }
        }
        for (const id in data) {
          if (data.hasOwnProperty(id) ) {
            propertiesArray.push(data[id]);
          }
        }
        return propertiesArray;
      })
    );
  }
  addProperty(property: any) {
    let newProp = [property];

    // Add new property in array if newProp alreay exists in local storage
    if (localStorage.getItem('newProp')) {
      newProp = [property,
                  ...JSON.parse(localStorage.getItem('newProp') || '{}')];
    }
    localStorage.setItem('newProp', JSON.stringify(newProp));}

  newPropID() {
    if (localStorage.getItem('Id')) {
      localStorage.setItem('PID', String(Number(localStorage.getItem('Id')) + 1));
      return Number(localStorage.getItem('Id'));
    } 
    else {
      localStorage.setItem('Id', '101');
      return 101;
    }
  }
  addClinic(val:any){
    return this.http.post('http://localhost:5000/api/Clinic',val);
  }
}
