/* Parameterübergabe an ein Programm */
using System;

public class Parameter {
  public static void Main(string [] args) {
    Console.WriteLine(
      "Anzahl der Parameter: " + args.Length + "\n"
    + "Erster Parameter:     " + args[0]     + "\n"
    + "Zweiter Paramter:     " + args[1]     + "\n"
    + "Dritter Parameter:    " + args[2]);
  }
}
