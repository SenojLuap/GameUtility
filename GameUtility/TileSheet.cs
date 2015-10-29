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


    public virtual void Draw(SpriteBatch spriteBatch, Vector2 pos, int frame, float scale = 1.0f) {
      Texture2D texture = GetTexture(TextureKey);
      if (texture != null) {
	Rectangle srcRect = GetSourceRectangle(frame);
	spriteBatch.Draw(texture, position: pos, sourceRectangle: srcRect, scale: new Vector2(scale, scale), color: Color.White);
      }
    }


    public virtual Rectangle GetSourceRectangle(int frame) {
      int xPos = frame % SizeInFrames.X;
      int yPos = frame / SizeInFrames.X;
      return new Rectangle(xPos * FrameWidth, yPos * FrameWidth, FrameWidth, FrameWidth);
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


}
