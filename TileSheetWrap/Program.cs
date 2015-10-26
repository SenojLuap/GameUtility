using paujo.GameUtility;

namespace TileSheetWrap {
  public class Program {
    static void Main(string[] args) {
      TileSheet tileSheet = new TileSheet();
      tileSheet.TextureKey = "FirstGame - Girl Farmer";
      tileSheet.FrameWidth = 32;
      tileSheet.FrameHeight = 48;

      Animation girlDown = new Animation();
      girlDown.AddFrame(0, 200.0);
      girlDown.AddFrame(1, 200.0);
      girlDown.AddFrame(2, 200.0);
      girlDown.AddFrame(1, 200.0);

      Animation girlLeft = new Animation();
      girlLeft.AddFrame(3, 200.0);
      girlLeft.AddFrame(4, 200.0);
      girlLeft.AddFrame(5, 200.0);
      girlLeft.AddFrame(4, 200.0);

      Animation girlRight = new Animation();
      girlRight.AddFrame(6, 200.0);
      girlRight.AddFrame(7, 200.0);
      girlRight.AddFrame(8, 200.0);
      girlRight.AddFrame(7, 200.0);

      Animation girlUp = new Animation();
      girlUp.AddFrame(9, 200.0);
      girlUp.AddFrame(10, 200.0);
      girlUp.AddFrame(11, 200.0);
      girlUp.AddFrame(10, 200.0);

      tileSheet.AddAnimation("girlDown", girlDown);
      tileSheet.AddAnimation("girlLeft", girlLeft);
      tileSheet.AddAnimation("girlRight", girlRight);
      tileSheet.AddAnimation("girlUp", girlUp);

      TileSheet.WriteToFile("girlTileSheet.json", tileSheet);

      TileSheet inSheet = TileSheet.ReadFromFile("girlTileSheet.json");
      if (inSheet != null) {
	System.Console.WriteLine(inSheet.TextureKey + " " + inSheet.FrameWidth + " " + inSheet.FrameHeight);
	foreach (var key in inSheet.AnimationKeys)
	  System.Console.WriteLine(key);
	System.Console.WriteLine(inSheet.AnimationCount);
      }
    }
  }
}
