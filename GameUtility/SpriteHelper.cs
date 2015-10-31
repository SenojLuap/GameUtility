using Microsoft.Xna.Framework;

namespace paujo.GameUtility {
  public class SpriteHelper : TileSheetHelper {

    public int Frame {
      get; set;
    }

    public SpriteHelper(TileSheet tileSheet, int frame, Vector2? pos = null, float? scale = 1f) : base(tileSheet, pos, scale) {
      Frame = frame;
    }


    public override int GetFrame() {
      return Frame;
    }
  }
}
