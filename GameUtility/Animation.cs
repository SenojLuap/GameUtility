using System;
using System.IO;
using System.Collections.Generic;

using Newtonsoft.Json;

using Microsoft.Xna.Framework;

namespace paujo.GameUtility {
  
  public class Animation {
    
    public List<int> Frames {
      get; set;
    }

    public List<double> FrameLengths {
      get; set;
    }

    public bool Repeatable {
      get; set;
    }

    
    [JsonIgnore]
    public double TotalLength {
      get {
	double runningTotal = 0.0;
	foreach (var time in FrameLengths)
	  runningTotal += time;
	return runningTotal;
      }
    }


    public Animation() {
      Frames = new List<int>();
      FrameLengths = new List<double>();
      Repeatable = true;
    }


    public void AddFrame(int frame, double length) {
      Frames.Add(frame);
      FrameLengths.Add(length);
    }


    public int GetFrameFromTime(double time) {
      double runningTime = 0.0;
      for (int i = 0; i < Frames.Count; i++) {
	runningTime += FrameLengths[i];
	if (runningTime > time) return Frames[i];
      }
      return Frames[Frames.Count - 1];
    }


  }


  public class AnimationHelper : TileSheetHelper {

    public Animation Animation {
      get; set; 
    }

    
    public double RunningTime {
      get; set;
    }


    [JsonIgnore]
    public bool Completed {
      get {
	if (Animation.Repeatable) return false;
	return RunningTime >= Animation.TotalLength;
      }
    }


    public AnimationHelper(TileSheet tileSheet, Animation animation, Point? pos = null, float scale = 1f, float depth = 1f)
    : base(tileSheet, pos, scale, depth) {
      Animation = animation;
    }


    public override void Update(GameTime gameTime) {
      if (!Completed) {
	RunningTime += gameTime.ElapsedGameTime.TotalMilliseconds;
	if (Animation.Repeatable && RunningTime >= Animation.TotalLength)
	  RunningTime -= Animation.TotalLength;
      }
    }


    public override int GetFrame() {
      return Animation.GetFrameFromTime(RunningTime);
    }


  }
  
}
