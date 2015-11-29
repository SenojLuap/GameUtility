using System;

using Microsoft.Xna.Framework;

namespace paujo.GameUtility {
  public class Circle {

    public Point Center {
      get; set;
    }

    
    public double Radius {
      get; set;
    }

    
    public double Area {
      get {
	return Math.PI * Radius * Radius;
      }
    }

    
    public Circle(Point center, double radius) {
      this.Center = center;
      this.Radius = radius;
    }
  }
}
