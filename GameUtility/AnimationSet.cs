using System;
using System.IO;

using Newtonsoft.Json;


namespace paujo.GameUtility {
  public class AnimationSet {

    public int[] StaticFrames {
      get; private set;
    }

    public string[] MovingAnimations {
      get; private set;
    }

    public void SetStaticFrames(int north, int east, int south, int west) {
      StaticFrames = new int[4];
      StaticFrames[0] = north;
      StaticFrames[1] = east;
      StaticFrames[2] = south;
      StaticFrames[3] = west;
    }

    public void SetMovingAnimations(string north, string east, string south,
				    string west) {
      MovingAnimations = new string[4];
      MovingAnimations[0] = north;
      MovingAnimations[1] = east;
      MovingAnimations[2] = south;
      MovingAnimations[3] = west;
    }


    public int GetStaticFrame(Direction direction) {
      if (StaticFrames == null) return -1;
      switch (direction) {
      case Direction.North:
	return StaticFrames[0];
      case Direction.East:
	return StaticFrames[1];
      case Direction.West:
	return StaticFrames[3];
      default:
	return StaticFrames[2];
      }
    }


    public string GetMovingAnimations(Direction direction) {
      if (MovingAnimations ==  null) return "";
      switch (direction) {
      case Direction.North:
	return MovingAnimations[0];
      case Direction.East:
	return MovingAnimations[1];
      case Direction.West:
	return MovingAnimations[3];
      default:
	return MovingAnimations[2];
      }
    }


    public static AnimationSet ReadFromFile(string filePath) {
      AnimationSet res = null;
      try {
	if (File.Exists(filePath)) {
	  string setAnimationSet = File.ReadAllText(filePath);
	  res = JsonConvert.DeserializeObject<AnimationSet>(setAnimationSet);
	}
      } catch (Exception e) {
	Misc.pln("Exception while parsing JSON file: " + e.Message);
      }
      return res;
    }


    public static void WriteToFile(string outputFile, AnimationSet animationSet) {
      string serAnimationSet = JsonConvert.SerializeObject(animationSet,
							   Formatting.Indented);
      File.WriteAllText(outputFile, serAnimationSet);
    }
  }
}
