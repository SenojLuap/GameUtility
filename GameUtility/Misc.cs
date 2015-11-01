using System;

namespace paujo.GameUtility {
  public class Misc {
    public static void pln(string msg) {
      System.Console.WriteLine(msg);
    }
    public static void pnn(string msg) {
      System.Console.Write(msg);
    }

    public static bool Eq(double left, double right, double epsilon = double.Epsilon) {
      return Math.Abs(left - right) < epsilon;
    }
  }
}

