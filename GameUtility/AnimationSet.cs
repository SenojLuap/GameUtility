using System;
using System.IO;

using Newtonsoft.Json;


namespace paujo.GameUtility {
  public class AnimationSet {

    public string[] StaticAnimations {
      get; private set;
    }

    public string[] SlowAnimations {
      get; private set;
    }

    public string[] FastAnimations {
      get; private set;
    }


    public void SetStaticAnimations(string northAnim, string eastAnim,
				    string southAnim, string westAnim) {
      StaticAnimations = new string[4];
      StaticAnimations[0] = northAnim;
      StaticAnimations[2] = southAnim;
      StaticAnimations[3] = westAnim;
    }


    public void SetSlowAnimations(string northAnim, string eastAnim,
				  string southAnim, string westAnim) {
      SlowAnimations = new string[4];
      SlowAnimations[0] = northAnim;
      SlowAnimations[1] = eastAnim;
      SlowAnimations[2] = southAnim;
      SlowAnimations[3] = westAnim;
    }

    
    public void SetFastAnimations(string northAnim, string eastAnim,
				  string southAnim, string westAnim) {
      FastAnimations = new string[4];
      FastAnimations[0] = northAnim;
      FastAnimations[1] = eastAnim;
      FastAnimations[2] = southAnim;
      FastAnimations[3] = westAnim;
    }

    
    public string GetStaticAnimation(Direction dir) {
      if (StaticAnimations == null)
	return "";
      switch (dir) {
      case Direction.North:
	return StaticAnimations[0];
      case Direction.East:
	return StaticAnimations[1];
      case Direction.West:
	return StaticAnimations[3];
      default:
	return StaticAnimations[2];
      }
    }
    
    
    public string GetSlowAnimation(Direction dir) {
      if (SlowAnimations == null)
	return GetStaticAnimation(dir);
      switch (dir) {
      case Direction.North:
	return SlowAnimations[0];
      case Direction.East:
	return SlowAnimations[1];
      case Direction.West:
	return SlowAnimations[3];
      default:
	return SlowAnimations[2];
      }
    }


    public string GetFastAnimation(Direction dir) {
      if (FastAnimations == null)
	return GetSlowAnimation(dir);
      switch (dir) {
      case Direction.North:
	return FastAnimations[0];
      case Direction.East:
	return FastAnimations[1];
      case Direction.West:
	return FastAnimations[3];
      default:
	return FastAnimations[2];
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
