/* Umrechnung der Marathonlaufstrecke */
using System;

public class Marathon {
  public static void Main() {
    double meilen, yards, kilometer;

    meilen=26.0;
    yards=385.0;

    kilometer=1.609*(meilen+yards/1760.0);

    Console.WriteLine("Die Länge des Marathonlaufs " +
                      "beträgt " + kilometer + " km");
  }
}
