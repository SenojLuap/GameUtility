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

    
    public static double Distance(Point p0, Point p1) {
      Vector2 v0 = PointToVector2(p0);
      Vector2 v1 = PointToVector2(p1);
      return Vector2.Distance(v0, v1);
    }
  }
}

