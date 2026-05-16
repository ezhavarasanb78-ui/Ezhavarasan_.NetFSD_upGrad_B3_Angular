import { Pipe,PipeTransform } from "@angular/core";
@Pipe({
  name: 'status'
})
export class Status implements PipeTransform {

  transform(value: boolean): string {
    return value ? 'Active' : 'Inactive';
  }

}