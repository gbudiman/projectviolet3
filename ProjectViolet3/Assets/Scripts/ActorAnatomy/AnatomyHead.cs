using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnatomyHead : ActorAnatomy {
  EquipEars equip_ears;
  EquipHead equip_head;
  EquipMask equip_mask;

  public AnatomyHead(): base() {
    
  }

  public override List<EquipSlot.Slot> MapAnatomySlot() {
    return new List<EquipSlot.Slot>() {
      EquipSlot.Slot.ears, EquipSlot.Slot.head, EquipSlot.Slot.mask
    };
  }

  public override void Equip(TacticalItem item) {
    
  }
}
