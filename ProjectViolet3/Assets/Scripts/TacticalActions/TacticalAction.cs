using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TacticalAction : IAction {
  public string name;
  public bool is_available;

  public TacticalAction() {
    is_available = false;
  }

  public void SetName(string _name) {
    name = _name;
  }
}
