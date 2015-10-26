using paujo.GameUtility;
using System.IO;

namespace paujo.TileMapWrap {
    public class Program {
        static void Main(string[] args) {
	  TileMap tileMap = new TileMap(10, 10);
	  //string[] spriteSheets = new string[1];
	  //spriteSheets[0] = "FirstGame - Girl Farmer";
	  //tileMap.SpriteSheets = spriteSheets;
	  tileMap.SpriteSheets.Add("FirstGame - Girl Farmer");
	  TileMap.WriteToFile("test.json", tileMap);

	  string fromFile = File.ReadAllText("test.json");
	  System.Console.WriteLine(fromFile);

	  TileMap readMap = TileMap.ReadFromFile("test.json");
	  if (readMap != null) {
	    System.Console.WriteLine(readMap.SpriteSheets[0]);
	  }
        }
    }
}
