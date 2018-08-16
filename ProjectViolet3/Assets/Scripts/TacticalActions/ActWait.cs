using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActWait : TacticalAction, IWaitUntil {
  public ActWait(): base() {
    base.SetName("Wait");
  }

  public void Act(TacticalGameObject other) {
    
  }
}
