/* Eingabe: Radius - Ausgabe: Fläche und Umfang des Kreises berechnet */
using System;

public class Radius {
  public static void Main() {
    double radius;

    Console.WriteLine("Bitte Kreisradius eingeben:");
    radius = double.Parse(Console.ReadLine());
    Console.WriteLine("Fläche: " + radius*radius*Math.PI + "\n"
                    + "Umfang: " + 2*Math.PI*radius);
  }
}
