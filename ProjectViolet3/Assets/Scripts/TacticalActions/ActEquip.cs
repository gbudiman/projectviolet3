using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActEquip : TacticalAction, IActOnSelf {
  public ActEquip(): base() {
    base.SetName("Equip Item");
    base.is_available = true;
  }

  public void Act() {
    
  }
}
