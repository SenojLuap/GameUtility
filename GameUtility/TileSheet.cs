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

    public Dictionary<int, Point> FrameOffsets {
      get; set;
    }

    public Point DefaultFrameOffset {
      get; set;
    }

    [JsonIgnore]
    public Dictionary<string, int>.KeyCollection AnimationKeys {
      get {
	return AnimationLookup.Keys;
      }
    }

    [JsonIgnore]
    public Point? _sizeInFrames = null;

    [JsonIgnore]
    public Point SizeInFrames {
      get {
	if (_sizeInFrames == null) {
	  Texture2D texture = GetTexture(TextureKey);
	  if (texture == null) {
	    _sizeInFrames = new Point(-1, -1);
	  } else {
	    int width = texture.Width / FrameWidth;
	    int height = texture.Height / FrameHeight;
	    _sizeInFrames = new Point(width, height);
	  }
	}
	return (Point)_sizeInFrames;
      }
      set {
	_sizeInFrames = value;
      }
    }

    [JsonIgnore]
    public int _tileCount = -1;

    [JsonIgnore]
    public int TileCount {
      get {
	if (_tileCount < 0) {
	  Point p = SizeInFrames;
	  if (p.X >= 0 && p.Y >= 0)
	    _tileCount = p.X * p.Y;
	  else
	    _tileCount = 0;
	}
	return _tileCount;
      }
      set {
	_tileCount = value;
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
      FrameOffsets = new Dictionary<int, Point>();
      DefaultFrameOffset = new Point(0, 0);
      FrameWidth = 1;
      FrameHeight = 1;
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


    public Point FrameOffset(int frame) {
      if (FrameOffsets.ContainsKey(frame))
	return FrameOffsets[frame];
      return DefaultFrameOffset;
    }

    
    public void Draw(SpriteBatch spriteBatch, Point pos, int frame, float scale = 1.0f, float depth = 1f, bool atOffset = true) {
      Texture2D texture = GetTexture(TextureKey);
      if (texture == null) return;
      Rectangle srcRect = GetSourceRectangle(frame);
      Point offset = (atOffset ? FrameOffset(frame) : new Point(0, 0));
      Rectangle destRect = GetDestinationRectangle(pos - offset, scale);
      spriteBatch.Draw(texture, sourceRectangle: srcRect, destinationRectangle: destRect, color: Color.White, layerDepth: depth);
    }


    public virtual Rectangle GetSourceRectangle(int frame) {
      int xPos = frame % SizeInFrames.X;
      int yPos = frame / SizeInFrames.X;
      return new Rectangle(xPos * FrameWidth, yPos * FrameHeight, FrameWidth, FrameHeight);
    }


    public Rectangle GetDestinationRectangle(Point pos, float scale) {
      return new Rectangle(pos.X, pos.Y, Convert.ToInt32(FrameWidth * scale), Convert.ToInt32(FrameHeight * scale));
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
    
    public IDrawHelper GetAnimationHelper(string animationKey) {
      Animation anim = AnimationByKey(animationKey);
      if (anim != null)
	return GetAnimationHelper(anim);
      return null;
    }
    
    
    public IDrawHelper GetAnimationHelper(Animation anim) {
      return new AnimationHelper(this, anim);
    }

    public IDrawHelper GetSpriteHelper(int frame) {
      return new SpriteHelper(this, frame);
    }
  }
}
