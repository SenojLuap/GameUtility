using System;

using Microsoft.Xna.Framework;

namespace paujo.GameUtility {
  public class Circle {

    public Point Center {
      get; set;
    }

    
    public int Radius {
      get; set;
    }

    
    public double Area {
      get {
	return Math.PI * (double)Radius * (double)Radius;
      }
    }

    
    public Circle(Point center, int radius) {
      this.Center = center;
      this.Radius = radius;
    }
  }
}
