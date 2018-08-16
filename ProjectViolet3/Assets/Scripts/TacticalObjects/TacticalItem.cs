using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TacticalItem : TacticalGameObject {
  public List<EquipSlot.Slot> target_slot;

  public void Start() {
    
  }

  public void Update() {
    
  }

  public void Spawn(string _name, EquipSlot.Slot t) {
    base.name = _name;
    target_slot = new List<EquipSlot.Slot>();
    SetTargetSlot(t);
  }

  private void SetTargetSlot(EquipSlot.Slot t) {
    target_slot.Add(t);
  }


}
