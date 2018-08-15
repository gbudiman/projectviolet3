using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IActTargetable {
  void Act(TacticalGameObject actor, TacticalGameObject target);
}

public interface IActAoeable {
  void Act(TacticalGameObject actor, Vector3 target);
}