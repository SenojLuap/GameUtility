using Microsoft.Xna.Framework.Input;

using System;
using System.Linq;
using System.Collections.Generic;

namespace paujo.GameUtility {
  public class AdvancedKeyboard {

    public Dictionary<Keys, AdvancedKeyState> States {
      get; set; 
    }

    public event EventHandler KeyChanged;

    public void Update(KeyboardState state) {
      Keys[] pressed = state.GetPressedKeys();
      //foreach (KeyValuePair<Keys, AdvancedKeyState> key in States) 
      foreach (var key in States) {
	if (!pressed.Contains(key.Key)) {
	  if (key.Value == AdvancedKeyState.Pressed ||
	      key.Value == AdvancedKeyState.Down) {
	    States[key.Key] = AdvancedKeyState.Released;
	    FireEvent(key.Key);
	  } else if (key.Value == AdvancedKeyState.Released) {
	    States.Remove(key.Key);
	  }
	}

	foreach (var pressedKey in pressed) {
	  if (!States.ContainsKey(pressedKey) ||
	      States[pressedKey] == AdvancedKeyState.Released) {
	    States[pressedKey] = AdvancedKeyState.Pressed;
	    FireEvent(pressedKey);
	  } else if (States[pressedKey] == AdvancedKeyState.Pressed) {
	    States[pressedKey] = AdvancedKeyState.Down;
	  }
	}
      }
    }


    public void FireEvent(Keys key) {
      if (KeyChanged != null)
	KeyChanged(this, new AdvancedKeyEventArgs(key, GetKeyState(key)));
    }


    public bool IsKeyDown(Keys key) {
      if (States.ContainsKey(key))
	if (States[key] == AdvancedKeyState.Pressed ||
	    States[key] == AdvancedKeyState.Down)
	  return true;
      return false;
    }


    public bool IsKeyUp(Keys key) {
      if (!States.ContainsKey(key) ||
	  States[key] == AdvancedKeyState.Released)
	return true;
      return false;
    }


    public AdvancedKeyState GetKeyState(Keys key) {
      if (States.ContainsKey(key)) return States[key];
      return AdvancedKeyState.Up;
    }
  }

  public enum AdvancedKeyState {
    Up = 0,
    Pressed = 1,
    Down = 2,
    Released = 3
  }


  public class AdvancedKeyEventArgs : EventArgs {
    

    public Keys Key {
      get; set;
    }

    public AdvancedKeyState State {
      get; set;
    }


    public AdvancedKeyEventArgs(Keys key, AdvancedKeyState state) {
      Key = key;
      State = state;
    }
  }
}
