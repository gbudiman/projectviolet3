using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TacticalEquipment : TacticalGameObject {
  EquipSlot.Slot target_slot;

  public void Start() {
    
  }

  public void Update() {
    
  }

  public void Spawn(EquipSlot.Slot t) {
    SetTargetSlot(t);
  }

  void SetTargetSlot(EquipSlot.Slot t) {
    target_slot = t;
  }


}
