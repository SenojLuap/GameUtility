using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace paujo.GameUtility {
  public interface IRenderJob {
    void Draw(SpriteBatch spriteBatch);
  }

  public struct TileSheetRenderJob : IRenderJob {

    public TileSheet TileSheet {
      get; set;
    }


    public int Frame {
      get; set;
    }


    public Point Pos {
      get; set;
    }

    
    public float Scale {
      get; set;
    }


    public float Rot { // Unimplemented
      get; set;
    }


    public float Depth {
      get; set;
    }


    public TileSheetRenderJob(TileSheet tileSheet, int frame, Point? pos = null, float scale = 1f, float rotation = 0f,
			      float depth = 1f) {
      if (pos == null) pos = new Point(0, 0);
      TileSheet = tileSheet;
      Frame = frame;
      Pos = (Point)pos;
      Scale = scale;
      Rot = rotation;
      Depth = depth;
    }

    
    public void Draw(SpriteBatch spriteBatch) {
      TileSheet.Draw(spriteBatch, Pos, Frame, Scale);
    }
  }
}
