﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnatomyArm : ActorAnatomy {
  EquipHand equip_hand;
  EquipArm equip_arm;
  public enum Slot { hand, arm };
  public enum Side { l, r };
  public Side side;
  Dictionary<Slot, EquipSlot> slots;

  public AnatomyArm() {
    slots = new Dictionary<Slot, EquipSlot>();
  }

  public void Equip(Slot target, TacticalEquipment item) {
    
  }

  public new List<EquipSlot.Slot> MapAnatomySlot() {
    List<EquipSlot.Slot> rets = new List<EquipSlot.Slot>() {
      EquipSlot.Slot.arm, EquipSlot.Slot.hands
    };

    if (side == Side.r) {
      rets.Add(EquipSlot.Slot.arm_2h);
    }

    return rets
  }
}
