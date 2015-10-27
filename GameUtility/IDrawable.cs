using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace paujo.GameUtility {
  public interface IDrawable {
    void Update(GameTime gameTime);
    void Draw(SpriteBatch spriteBatch, Vector2 pos, float scale, float layer);
  }
}
