using System;

public class Except04 {
  public static void Main() {
    int divident=30, divisor, quotient;

    for(divisor=3; divisor>=-3; divisor--) {
      try {
        quotient=divident/divisor;
        Console.WriteLine("Quotient: " + quotient);
      }
      catch(DivideByZeroException e) {
        Console.WriteLine("Message:    " + e.Message + "\n" +
                          "StackTrace: " + e.StackTrace);
      }
    }
  }
}