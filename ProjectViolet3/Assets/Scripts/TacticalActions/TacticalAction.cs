using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TacticalAction : IAction {
  public string name;
  public bool is_available;
  public TacticalActor actor;

  public TacticalAction(TacticalActor _actor) {
    is_available = false;
    actor = _actor;
  }

  public void SetName(string _name) {
    name = _name;
  }
}
