using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActorAnatomy : IAnatomyMappable {
  public enum Anatomy {
    head, arm_l, arm_r, body, leg_l, leg_r
  };
  public Dictionary<EquipSlot.Slot, EquipSlot> slots;
  public abstract List<EquipSlot.Slot> MapAnatomySlot();

  public ActorAnatomy() {
    slots = new Dictionary<EquipSlot.Slot, EquipSlot>();
  }

  public abstract void Equip(TacticalItem item);
}