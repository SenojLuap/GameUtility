using System;
using System.IO;
using System.Collections.Generic;

using Newtonsoft.Json;

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
	if (runningTime > time) return i;
      }
      return Frames.Count - 1;
    }
  }
  
}
