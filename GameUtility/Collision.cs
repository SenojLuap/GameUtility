using System;
using Microsoft.Xna.Framework;

namespace paujo.GameUtility {
  public class Collision {

    public static bool Collides(Circle circle0, Circle circle1) {
      return (circle0.Radius + circle1.Radius) >
	Misc.Distance(circle0.Center, circle1.Center);
    }

    public static bool Collides(Rectangle rect0, Rectangle rect1) {
      return !(rect0.Left > rect1.Right ||
	       rect0.Right < rect1.Left ||
	       rect0.Top < rect1.Bottom ||
	       rect0.Bottom > rect1.Top);
    }


    public static bool Collides(Rectangle rect, Circle circle) {
      int distX = Math.Abs(circle.Center.X - rect.Center.X);
      int distY = Math.Abs(circle.Center.Y - rect.Center.Y);

      if (distX > (rect.Width/2 + circle.Radius)) return false;
      if (distY > (rect.Height/2 + circle.Radius)) return false;

      if (distX <= (rect.Width/2)) return true;
      if (distY <= (rect.Height/2)) return true;

      double cornerDistSq = Math.Pow((distX - rect.Width/2), 2.0) +
	Math.Pow((distY - rect.Height/2), 2.0);

      return (cornerDistSq < (circle.Radius * circle.Radius));
    }
  }
}
