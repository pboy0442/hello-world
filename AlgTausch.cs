/* Algorithmus zum Vertauschen zweier Zahlen */
using System;

public class AlgTausch {
  public static void Main() {
    double a, b, h;
    int i, n;

    Console.WriteLine("Bitte ganze Zahl eingeben");
    n=Int32.Parse(Console.ReadLine());
    Console.WriteLine("Berechnung für {0} Durchläufe", n);
    Console.WriteLine("+++++++++++++++++++++++++++++", n);

    for (i=1; i<=n; i++) {
      Console.Write("Bitte 1. reele Zahlen eingeben: ");
      a=Double.Parse(Console.ReadLine());
      Console.Write("Bitte 2. reele Zahlen eingeben: ");
      b=Double.Parse(Console.ReadLine());
      if (a>b) {
        h=a;
        a=b;
        b=h;
      }
      Console.WriteLine("Ergebnis a={0:F4}, b={1:F4}", a, b);
    }
  }
}
