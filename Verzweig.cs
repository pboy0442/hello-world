/* Bedingte Programmausführung */
using System;

public class Verzweig {
  public static void Main(string [] args) {
    int zahl1, zahl2;

    zahl1 = Int32.Parse(args[0]);
    zahl2 = Int32.Parse(args[1]);

    if (zahl2 != 0) {
      Console.WriteLine(zahl1 + "/" + zahl2 + "=" + zahl1/zahl2);
    }
  }
}
