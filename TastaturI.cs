/* Eingabe über die Tastatur */
using System;

public class TastaturI {
  public static void Main() {
    int zahl1, zahl2;

    Console.WriteLine("Bitte erste Zahl eingeben:");
    zahl1 = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Bitte zweite Zahl eingeben:");
    zahl2 = Int32.Parse(Console.ReadLine());

    Console.WriteLine("Die Summe der Zahlen ist: " + (zahl1 + zahl2));
  }
}
