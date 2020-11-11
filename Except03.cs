//Programmcode der Fehler enthalten/erzeugen kann wird mittels try/catch-Block eingegrenzt
using System;

public class Except03 {
  public static void Main() {
    int divident=30, divisor, quotient;

    for(divisor=3; divisor>=-3; divisor--) {
      try {
        quotient=divident/divisor;
        Console.WriteLine("Quotient: " + quotient);
      }
      catch {
        Console.WriteLine("Abbruch: Division durch null!");
      }
    }
  }
}