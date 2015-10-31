using Microsoft.Xna.Framework;


namespace paujo.GameUtility {
  public interface IDrawHelper {
    void Update(GameTime gameTime);
    IRenderJob GetRenderJob();
  }
}
