import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'exponentialstrength'
})
export class ExponentialstrengthPipe implements PipeTransform {

  // transform(value: unknown, ...args: unknown[]): unknown {
  //   return null;
  // }
  
  transform(value: number, exponent = 1): number {
    return Math.pow(value, exponent);
  }

}
