using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace paujo.GameUtility {
  public class Renderer {

    public Game Game {
      get; set;
    }

    public SortedDictionary<int, List<IRenderJob>> RenderJobs {
      get; set;
    }

    public Renderer(Game game) {
      RenderJobs = new SortedDictionary<int, List<IRenderJob>>();
      Game = game;
    }


    public void AddJob(IRenderJob job, int layer) {
      List<IRenderJob> layerList = RenderJobs[layer];
      if (layerList == null) {
	layerList = new List<IRenderJob>();
	RenderJobs.Add(layer, layerList);
      }
      layerList.Add(job);
    }


    public void Draw() {
      foreach (KeyValuePair<int, List<IRenderJob>> keyValue in RenderJobs) {
	SpriteBatch spriteBatch = new SpriteBatch(Game.GraphicsDevice);
	spriteBatch.Begin();
	foreach (var renderJob in keyValue.Value) {
	  renderJob.Draw(spriteBatch);
	}
	spriteBatch.End();
      }
    }


    public void Reset() {
      RenderJobs.Clear();
    }
  }
}
