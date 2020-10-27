/* Parameterübergabe und Summe von ganzen Zahlen */
using System;

public class ParameterI {
  public static void Main(string [] args) {
    int zahl1, zahl2;

    zahl1 = Int32.Parse(args[0]);
    zahl2 = Int32.Parse(args[1]);

    Console.WriteLine("Die Summe der Zahlen ist: " + (zahl1 + zahl2));
  }
}
