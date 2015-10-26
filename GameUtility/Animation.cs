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
    }


    public void AddFrame(int frame, double length) {
      Frames.Add(frame);
      FrameLengths.Add(length);
    }
  }
  
}
