/* Summe der ganzen Zahlen von 1 bis 5 */
using System;

public class Sum2five {
  public static void Main() {
    int zahl, summe;
    summe=0;

    for(zahl=1; zahl<=5; zahl=zahl+1) {
      summe = summe+zahl;
    }

    Console.WriteLine("Die Summe der Zahlen ist " + summe + ".");
  }
}
