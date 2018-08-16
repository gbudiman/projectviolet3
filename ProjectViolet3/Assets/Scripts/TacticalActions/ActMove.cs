using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActMove : TacticalAction, IActPathable {
  public ActMove(TacticalActor actor): base(actor) {
    base.SetName("Move");
    base.is_available = true;
  }

  public void Act(Vector3 direction) {
    
  }
	
}
