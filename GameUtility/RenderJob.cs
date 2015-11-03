using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace paujo.GameUtility {
  public interface IRenderJob {
    void Draw(SpriteBatch spriteBatch);
  }

  public class TileSheetRenderJob : IRenderJob {

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
    } = 1.0f;


    public float Rot { // Unimplemented
      get; set;
    }

    
    public void Draw(SpriteBatch spriteBatch) {
      TileSheet.Draw(spriteBatch, Pos, Frame, Scale);
    }
  }
}
