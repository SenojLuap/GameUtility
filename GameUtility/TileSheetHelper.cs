using Microsoft.Xna.Framework;

namespace paujo.GameUtility {
  public abstract class TileSheetHelper : IDrawHelper {

    public TileSheet TileSheet {
      get; set;
    }

    public Point Pos {
      get; set;
    }

    public float Scale {
      get; set;
    }

    public float Depth {
      get; set;
    }

    public TileSheetHelper(TileSheet tileSheet, Point? pos = null, float scale = 1f, float depth = 1f) {
      TileSheet = tileSheet;
      
      if (pos == null) pos = new Point(0, 0);
      Pos = (Point)pos;
      Scale = scale;
      Depth = depth;
    }


    public abstract int GetFrame();

    public virtual void Update(GameTime gameTime) {
      // Do nothing
    }

    public virtual IRenderJob GetRenderJob() {
      TileSheetRenderJob job = new TileSheetRenderJob();
      job.TileSheet = TileSheet;
      job.Frame = GetFrame();
      job.Pos = Pos;
      job.Scale = Scale;
      job.Depth = Depth;
      return job;
    }
  }
}
