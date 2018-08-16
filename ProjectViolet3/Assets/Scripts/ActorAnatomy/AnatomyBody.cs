using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnatomyBody : ActorAnatomy {
  EquipBack equip_back;
  EquipBody equip_body;
  EquipHip equip_hip;
  EquipWaist equip_waist;

  public AnatomyBody(): base() {
    
  }

  public override List<EquipSlot.Slot> MapAnatomySlot() {
    return new List<EquipSlot.Slot>() {
      EquipSlot.Slot.back, EquipSlot.Slot.body, EquipSlot.Slot.hip, EquipSlot.Slot.waist
    };
  }

  public override void Equip(TacticalItem item) {
    
  }
}
