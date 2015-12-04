using Microsoft.Xna.Framework.Graphics;

using System.Collections.Generic;

namespace paujo.GameUtility {
  public class ListRenderJob {

    public List<IRenderJob> List {
      get; set;
    }

    public ListRenderJob() {
      List = new List<IRenderJob>();
    }

    public void Add(IRenderJob newJob) {
      List.Add(newJob);
    }

    public void Draw(SpriteBatch spriteBatch) {
      foreach (var item in List)
	item.Draw(spriteBatch);
    }
  }
}
