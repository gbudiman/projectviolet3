using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EquipSlot {
  public enum Slot {
    hands, arm_l, arm_r, arm_2h,
    back, body, hip, waist,
    ears, head, mask,
    feet, legs
  };

  TacticalItem item;

  public EquipSlot() {
    item = null;
  }

  public void Assign(TacticalItem _item) {
    item = _item;
  }

  public TacticalItem Detach() {
    var cached = item;
    item = null;

    return cached;
  }

  public TacticalItem Get() {
    return item;
  }

  public bool IsEmpty() {
    return item == null;
  }
}
