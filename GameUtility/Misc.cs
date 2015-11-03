using System;

using Microsoft.Xna.Framework;

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

    
    public static Point Vector2ToPoint(Vector2 vector) {
      return new Point(Convert.ToInt32(vector.X), Convert.ToInt32(vector.Y));
    }


    public static Vector2 PointToVector2(Point point) {
      return new Vector2(point.X, point.Y);
    }
  }
}

