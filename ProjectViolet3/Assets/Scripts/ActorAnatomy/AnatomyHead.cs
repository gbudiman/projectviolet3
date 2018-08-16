using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnatomyHead : ActorAnatomy {
  EquipEars equip_ears;
  EquipHead equip_head;
  EquipMask equip_mask;

  public AnatomyHead() {
    
  }

  public new List<EquipSlot.Slot> MapAnatomySlot() {
    return new List<EquipSlot.Slot>() {
      EquipSlot.Slot.ears, EquipSlot.Slot.head, EquipSlot.Slot.mask
    };
  }
}
