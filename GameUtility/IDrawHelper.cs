using Microsoft.Xna.Framework;


namespace paujo.GameUtility {
  public interface IDrawHelper {
    void Update(GameTime gameTime);
    void Update(double deltaTime);
    IRenderJob GetRenderJob();
  }
}
