using Microsoft.Xna.Framework.Graphics;

namespace paujo.GameUtility {
  public class InvisibleRenderJob : IRenderJob {
    public void Draw(SpriteBatch spriteBatch) {
      // Nothing
    }

    private InvisibleRenderJob() {
    }

    private static InvisibleRenderJob instance;

    static InvisibleRenderJob() {
      instance = new InvisibleRenderJob();
    }

    public static InvisibleRenderJob Instance() {
      return instance;
    }
  }
}
