using Microsoft.Xna.Framework;

namespace paujo.GameUtility {
  public class SpriteHelper : TileSheetHelper {

    public int Frame {
      get; set;
    }

    public SpriteHelper(TileSheet tileSheet, int frame, Point? pos = null, float scale = 1f, float depth = 1f)
    : base(tileSheet, pos, scale, depth) {
      Frame = frame;
    }


    public override int GetFrame() {
      return Frame;
    }
  }
}
