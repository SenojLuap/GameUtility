using System;

using paujo.GameUtility;

namespace TileSheetWrap {
  public class Program {
    static void Main(string[] args) {
      string response;
      bool boolResponse;
	
      TileSheet sheet = GetTileSheetFromUser();
      if (sheet != null) {
	pln(" -- Animations --");
	pln("Add Animation (True/False): ");
	Boolean.TryParse(getLine(), out boolResponse);
	while (boolResponse) {
	  Animation newAnim = GetAnimationFromUser();
	  if (newAnim != null) {
	    pnn("AnimationKey: ");
	    response = getLine();
	    if (response.Length > 0)
	      sheet.AddAnimation(response, newAnim);
	    else
	      sheet.AddAnimation(newAnim);
	  }
	  pln("Add Animation (True/False): ");
	  Boolean.TryParse(getLine(), out boolResponse);
	}
	
	pnn("Output base file name: ");
	response = getLine();
	if (response.Length > 0)
	  TileSheet.WriteToFile(response + ".jts", sheet);
	pln("Done.");
      }
    }


    public static Animation GetAnimationFromUser() {
      pln(" -- New Animation --");
      string response;
      int numResponse;
      double dblResponse;
      Animation res = new Animation();

      pnn("Repeatable (yes/no): ");
      response = getLine();
      if (response == "no")
	res.Repeatable = false;
      
      do {
	pnn("Frame (-1 to end): ");
	Int32.TryParse(getLine(), out numResponse);
	if (numResponse >= 0) {
	  pnn("Frame Length (in ms): ");
	  Double.TryParse(getLine(), out dblResponse);
	  res.AddFrame(numResponse, dblResponse);
	}
      } while (numResponse >= 0);

      if (res.Frames.Count > 0)
	return res;
      return null;
    }


    public static TileSheet GetTileSheetFromUser() {
      pln(" -- Tile Sheet --");
      TileSheet tileSheet = new TileSheet();
      pnn("TextureKey: ");
      string response = getLine();
      tileSheet.TextureKey = response;
      
      pnn("FrameWidth: ");
      int numResponse;
      Int32.TryParse(getLine(), out numResponse);
      tileSheet.FrameWidth = numResponse;
      
      pnn("FrameHeight: ");
      Int32.TryParse(getLine(), out numResponse);
      tileSheet.FrameHeight = numResponse;
      
      return tileSheet;
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
