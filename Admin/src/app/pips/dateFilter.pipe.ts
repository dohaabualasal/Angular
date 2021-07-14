import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'dateFilter'
})
export class DateFilterPipe implements PipeTransform {

  transform(value: any[], filterString: any, propName: string):any {
    const resultArray = [];
    
    if (value) {
      if (value.length === 0 || filterString === '' || propName === '') {
        return value;
      }

      for (const item of value) {
        if (item[propName].substr(0,10) === filterString) {
          resultArray.push(item);
        }
      }
      return resultArray;
    }
  }


}
