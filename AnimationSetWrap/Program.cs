using System;

using paujo.GameUtility;

namespace paujo.AnimationSetWrap {
  public class Program {
    static void Main(string[] args) {
      string response;
      int intResponse;
      
      pnn("TileSheet: ");
      response = getLine();
      TileSheet tileSheet = TileSheet.ReadFromFile(response + ".jts");
      if (tileSheet == null) {
	pln("FAIL!");
	return;
      }
      pln(" -- Static Frames --");
      pnn("North Facing: ");
      Int32.TryParse(getLine(), out intResponse);
      int north = intResponse;
      pnn("East Facing: ");
      Int32.TryParse(getLine(), out intResponse);
      int east = intResponse;
      pnn("South Facing: ");
      Int32.TryParse(getLine(), out intResponse);
      int south = intResponse;
      pnn("West Facing: ");
      Int32.TryParse(getLine(), out intResponse);
      int west = intResponse;
      pln(" -- Animations -- ");
      foreach (var anim in tileSheet.AnimationKeys)
	pln(anim);
      pnn("North Anim: ");
      string northAnim = getLine();
      pnn("East Anim: ");
      string eastAnim = getLine();
      pnn("South Anim: ");
      string southAnim = getLine();
      pnn("West Anim: ");
      string westAnim = getLine();
      
      AnimationSet res = new AnimationSet();
      res.SetStaticFrames(north, east, south, west);
      res.SetMovingAnimations(northAnim, eastAnim, southAnim, westAnim);
      
      pnn("Output base file name: ");
      response = getLine();
      if (response.Length > 0)
	AnimationSet.WriteToFile(response + ".jas", res);
      pln("Done.");
    }



    public static void pln(string msg) {
      System.Console.WriteLine(msg);
    }

    public static void pnn(string msg) {
      System.Console.Write(msg);
    }

    public static string getLine() {
      return System.Console.ReadLine();
    }
  }
}
