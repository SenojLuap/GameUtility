using System;
using System.IO;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Newtonsoft.Json;

namespace paujo.GameUtility {
  public class TileSheet {

    public string TextureKey {
      get; set;
    }

    public delegate Texture2D GetTextureDelegate(string textureKey);

    [JsonIgnore]
    public GetTextureDelegate GetTexture;

    public int FrameWidth {
      get; set;
    }

    public int FrameHeight {
      get; set;
    }

    public List<Animation> Animations {
      get; set;
    }

    public Dictionary<string, int> AnimationLookup {
      get; set;
    }

    [JsonIgnore]
    public Dictionary<string, int>.KeyCollection AnimationKeys {
      get {
	return AnimationLookup.Keys;
      }
    }


    [JsonIgnore]
    public Point SizeInFrames {
      get {
	Texture2D texture = GetTexture(TextureKey);
	if (texture == null) return new Point(-1, -1);
	int width = texture.Width / FrameWidth;
	int height = texture.Height / FrameHeight;
	return new Point(width, height);
      }
    }

    [JsonIgnore]
    public int TileCount {
      get {
	Point p = SizeInFrames;
	if (p.X >= 0 && p.Y >= 0)
	  return p.X * p.Y;
	return 0;
      }
    }

    [JsonIgnore]
    public int AnimationCount {
      get {
	return Animations.Count;
      }
    }

    public TileSheet() {
      GetTexture = delegate(string s) { return null; };
      Animations = new List<Animation>();
      AnimationLookup = new Dictionary<string, int>();
    }


    public void AddAnimation(string key, Animation newAnim) {
      AnimationLookup.Add(key, Animations.Count);
      Animations.Add(newAnim);
    }

    
    public void AddAnimation(Animation newAnim) {
      Animations.Add(newAnim);
    }

    public Animation AnimationByKey(string key) {
      if (AnimationLookup.ContainsKey(key)) {
	int index = AnimationLookup[key];
	return Animations[index];
      }
      return null;
    }


    public virtual void Draw(SpriteBatch spriteBatch, Vector2 pos, int frame, float scale = 1.0f, float layer = 0f) {
      Texture2D texture = GetTexture(TextureKey);
      if (texture != null) {
	Rectangle srcRect = GetSourceRectangle(frame);
	spriteBatch.Draw(texture, position: pos, sourceRectangle: srcRect, scale: new Vector2(scale, scale), color: Color.White,
			 layerDepth: layer);
      }
    }


    public virtual void Draw(SpriteBatch spriteBatch, int x, int y, int frame, float scale = 1.0f, float layer = 0f) {
      Draw(spriteBatch, new Vector2((float)x, (float)y), frame, scale, layer);
    }


    public virtual void Draw(SpriteBatch spriteBatch, float x, float y, int frame, float scale = 1.0f, float layer = 0f) {
      Draw(spriteBatch, new Vector2(x, y), frame, scale, layer);
    }


    public virtual Rectangle GetSourceRectangle(int frame) {
      int xPos = frame % SizeInFrames.X;
      int yPos = frame / SizeInFrames.X;
      return new Rectangle(xPos * FrameWidth, yPos * FrameWidth, FrameWidth, FrameWidth);
    }


    public IDrawable GetSpriteDrawable(int frame) {
      return new StaticSprite(this, frame);
    }


    public IDrawable GetAnimationDrawable(int animationIndex, double timeScale = 1.0) {
      if (animationIndex < Animations.Count)
	return new AnimatedSprite(this, animationIndex, timeScale);
      return null;
    }

    public IDrawable GetAnimationDrawable(string animationKey, double timeScale = 1.0) {
      if (AnimationLookup.ContainsKey(animationKey)) {
	int index = AnimationLookup[animationKey];
	return new AnimatedSprite(this, index, timeScale);
      }
      return null;
    }


    public IDrawable GetAnimationDrawable(Animation anim, double timeScale = 1.0) {
      int index = Animations.IndexOf(anim);
      if (index >= 0)
	return new AnimatedSprite(this, index, timeScale);
      return null;
    }

    
    public static void WriteToFile(string outputFile, TileSheet tileSheet) {
      string serTileSheet = JsonConvert.SerializeObject(tileSheet, Formatting.Indented);
      File.WriteAllText(outputFile, serTileSheet);
    }


    public static TileSheet ReadFromFile(string filePath) {
      TileSheet res = null;
      try {
	if (File.Exists(filePath)) {
	  string serTileSheet = File.ReadAllText(filePath);
	  res = JsonConvert.DeserializeObject<TileSheet>(serTileSheet);
	}
      } catch (Exception e) {
	System.Console.WriteLine("Exception while parsing JSON file: " + e.Message);
      }
      return res;
    }

  }


  public class StaticSprite : IDrawable {

    public TileSheet TileSheet {
      get; set;
    }

    public int Frame {
      get; set;
    }


    public StaticSprite(TileSheet tileSheet, int frame) {
      TileSheet = tileSheet;
      Frame = frame;
    }

    public void Update(GameTime gameTime) {
      // Do nothing.
    }


    public void Draw(SpriteBatch spriteBatch, Vector2 pos, float scale, float layer) {
      TileSheet.Draw(spriteBatch, pos, Frame, scale, layer);
    }
  }


  public class AnimatedSprite : IDrawable {

    public TileSheet TileSheet {
      get; set;
    }

    public int AnimationIndex {
      get; set;
    }

    public double RunningTime {
      get; set;
    }

    public double TimeScale {
      get; set;
    }

    public bool Complete {
      get; set;
    }

    public Animation Animation {
      get {
	if (TileSheet != null && AnimationIndex >= 0)
	  return TileSheet.Animations[AnimationIndex];
	return null;
      }
    }


    public AnimatedSprite(TileSheet tileSheet, int animationIndex, double timeScale = 1.0) {
      TileSheet = tileSheet;
      AnimationIndex = animationIndex;
      RunningTime = 0.0;
      TimeScale = 1.0;
    }


    public void Update(GameTime gameTime) {
      if (!Complete) {
	RunningTime += (gameTime.ElapsedGameTime.TotalMilliseconds * TimeScale);
	if (RunningTime >= Animation.TotalLength) {
	  if (Animation.Repeatable)
	    RunningTime -= Animation.TotalLength;
	  else
	    Complete = true;
	}
      }
    }


    public void Draw(SpriteBatch spriteBatch, Vector2 pos, float scale, float depth) {
      int frame = Animation.GetFrameFromTime(RunningTime);
      if (frame >= 0)
	TileSheet.Draw(spriteBatch, pos, frame, scale, depth);
    }


    public void Reset() {
      RunningTime = 0.0;
      Complete = false;
    }


    
  }
}
