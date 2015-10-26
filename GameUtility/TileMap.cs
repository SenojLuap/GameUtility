using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace paujo.GameUtility {
    public class TileMap {

      public List<string> SpriteSheets {
	get; set;
      }

      public int Width {
	get; private set;
      }

      public int Height {
	get; private set;
      }

      public TileMap(int width, int height)  {
	SpriteSheets = new List<string>();
	Width = width;
	Height = height;
      }

      public static void WriteToFile(string outputPath, TileMap tileMap) {
	string serTileMap = JsonConvert.SerializeObject(tileMap);
	File.WriteAllText(outputPath, serTileMap);
      }

      public static TileMap ReadFromFile(string filePath) {
	TileMap res = null;
	try {
	  if (File.Exists(filePath)) {
	    string serTileMap = File.ReadAllText(filePath);
	    res = JsonConvert.DeserializeObject<TileMap>(serTileMap);
	  }
	} catch {
	  System.Diagnostics.Debug.WriteLine("Exception while parsing JSON file");
	}
	return res;
      }
    }
}
