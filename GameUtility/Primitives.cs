using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace paujo.GameUtility {
  public class Primitives {

    static public Texture2D Pixel;

    static public bool Initialized = false;

    static public void Initialize(Game game) {
      Pixel = new Texture2D(game.GraphicsDevice, 1, 1);
      Color[] initColor = new Color[1];
      initColor[0] = Color.White;
      Pixel.SetData<Color>(initColor);
      
      Initialized = true;
    }

    
  }


  public struct PixelRenderJob : IRenderJob {

    public Point Pos {
      get; set;
    }

    public Color Color {
      get; set;
    }

    public PixelRenderJob(Point pos, Color? color = null) {
      if (color == null) color = Color.White;
      Pos = pos;
      Color = (Color)color;
    }

    public void Draw(SpriteBatch spriteBatch) {
      if (Primitives.Initialized)
	spriteBatch.Draw(Primitives.Pixel, new Rectangle(Pos.X, Pos.Y, 1, 1), Color);
    }
  }


  public struct LineRenderJob : IRenderJob {

    public Point Pos {
      get; set;
    }

    public Point Pos2 {
      get; set;
    }

    public Color Color {
      get; set;
    }

    public int Thickness {
      get; set;
    }

    public LineRenderJob(Point pos, Point pos2, int thickness = 1, Color? color = null) {
      if (color == null) color = Color.White;
      Pos = pos;
      Pos2 = pos2;
      Color = (Color)color;
      Thickness = thickness;
    }


    public void Draw(SpriteBatch spriteBatch ) {
      if (!Primitives.Initialized) {
	Misc.pln("Attempted to draw primitive without initializing!");
	return;
      }
      double deltaX = Pos2.X - Pos.X;
      double deltaY = Pos2.Y - Pos.Y;
      int length = Convert.ToInt32(Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY)));

      double angle = Math.Atan2(deltaY, deltaX);

      Rectangle target = new Rectangle(Pos.X - (Thickness / 2), Pos.Y - (Thickness / 2), length, Thickness);
      spriteBatch.Draw(Primitives.Pixel, destinationRectangle: target, origin: new Vector2(0, (float)(Thickness / 2)),
		       rotation: (float)angle, color: Color);
    }
  }


  public struct RectRenderJob : IRenderJob {

    public Rectangle Rectangle {
      get; set;
    }


    public Color Color {
      get; set;
    }


    public RectRenderJob(Rectangle rect, Color? color = null) {
      if (color == null) color = Color.White;
      Rectangle = rect;
      Color = (Color)color;
    }


    public RectRenderJob(int x, int y, int width, int height, Color? color = null) {
      if (color == null) color = Color.White;
      Rectangle = new Rectangle(x, y, width, height);
      Color = (Color)color;
    }


    public void Draw(SpriteBatch spriteBatch) {
      if (!Primitives.Initialized) {
	Misc.pln("Attempted to draw primitive without initializing!");
	return;
      }

      spriteBatch.Draw(Primitives.Pixel, Rectangle, Color);
    }
  }
}
