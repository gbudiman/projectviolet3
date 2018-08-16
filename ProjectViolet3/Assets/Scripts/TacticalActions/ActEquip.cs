using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActEquip : TacticalAction {
  public ActEquip(TacticalActor actor): base(actor) {
    base.SetName("Equip Item");
    base.is_available = true;
  }

  public void Act(TacticalEquipment equipment, EquipSlot.Slot slot) {
    
  }
}
