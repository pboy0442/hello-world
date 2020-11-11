using System;

public class Except10 {
  public static void Main() {
    int [] divident = {30,60};
    int divisor, quotient;

    for(divisor=1; divisor>=-1; divisor--) {
      for(int j=0;j<=2;j++) {
        try {
          quotient=divident[j]/divisor;
          Console.WriteLine("Quotient: " + quotient);
        }
        catch(DivideByZeroException) {
          Console.WriteLine("Division durch null.");
        }
        catch(IndexOutOfRangeException) {
          Console.WriteLine("Überschreitung der Feldgrenzen.");
        }
      }
    }
  }
}