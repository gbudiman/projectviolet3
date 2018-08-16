using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnatomyArms : ActorAnatomy {
  EquipHands equip_hands_l;
  EquipHands equip_hands_r;
  EquipArms equip_arms_l;
  EquipArms equip_arms_r;
  public enum Slot { hands_l, hands_r, arms_l, arms_r };

  Dictionary<Slot, EquipSlot> slots;

  public AnatomyArms() {
    slots = new Dictionary<Slot, EquipSlot>();
  }

  public void Equip(Slot target, TacticalEquipment item) {
    
  }
}
