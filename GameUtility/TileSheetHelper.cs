using Microsoft.Xna.Framework;

namespace paujo.GameUtility {
  public abstract class TileSheetHelper : IDrawHelper {

    public TileSheet TileSheet {
      get; set;
    }

    public Vector2 Pos {
      get; set;
    }

    public float Scale {
      get; set;
    }

    public TileSheetHelper(TileSheet tileSheet, Vector2? pos = null, float? scale = 1f) {
      TileSheet = tileSheet;
      
      if (pos == null) pos = new Vector2(0f, 0f);
      Pos = (Vector2)pos;
      Scale = (float)scale;
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
      return job;
    }
  }
}
