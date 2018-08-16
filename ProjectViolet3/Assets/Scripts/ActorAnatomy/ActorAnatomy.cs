using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActorAnatomy : IAnatomyMappable {
  public enum Anatomy {
    head, arm_l, arm_r, body, leg_l, leg_r
  };

  public List<EquipSlot.Slot> MapAnatomySlot() {
    return new List<EquipSlot.Slot>();
  }
}
