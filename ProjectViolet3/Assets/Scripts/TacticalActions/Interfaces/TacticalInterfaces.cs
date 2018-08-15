using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAction {
  void SetName(string _name);
}
public interface IActItemOnSelf {
  void Act(TacticalGameObject item);
}

public interface IActOnSelf {
  void Act();
}

public interface IActTargetable {
  void Act(TacticalGameObject actor, TacticalGameObject target);
}

public interface IActAoeable {
  void Act(TacticalGameObject actor, Vector3 target);
}