using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnatomyArm : ActorAnatomy {
  const bool BYPASS_DETACH = true;
  EquipHand equip_hand;
  EquipArm equip_arm;
  public enum Slot { hand, arm };
  public enum Side { l, r };
  public Side side;
  AnatomyArm pair;

  public AnatomyArm(Side _side): base() {
    side = _side;
    equip_hand = new EquipHand();
    equip_arm = new EquipArm();
  }

  public void RegisterPair(AnatomyArm other) {
    pair = other;
  }

  public override void Equip(TacticalItem item) {
    EquipSlot.Slot target_slot = item.target_slot[0];

    Attach(target_slot, item);
    if (target_slot == EquipSlot.Slot.arm_2h) {
      Attach(EquipSlot.Slot.arm_r, item);
      pair.Attach(EquipSlot.Slot.arm_l, item);
    }
  }

  public override void UnEquip() {
    DetachAll();
  }

  public override void UnEquip(EquipSlot.Slot slot) {
    TacticalItem item = Detach(slot);
    if (item != null && item.target_slot[0] == EquipSlot.Slot.arm_2h) {
      switch (side) {
        case Side.l: 
          pair.UnEquip(EquipSlot.Slot.arm_r);
          pair.UnEquip(EquipSlot.Slot.arm_2h);
          break;
        case Side.r:
          pair.UnEquip(EquipSlot.Slot.arm_l);
          break;
      }

    }
  }

  TacticalItem Detach(EquipSlot.Slot _slot) {
    EquipSlot slot;
    slots.TryGetValue(_slot, out slot);
    return slot.Detach();
  }

  void DetachAll() {
    foreach (KeyValuePair<EquipSlot.Slot, EquipSlot> pair in slots) {
      pair.Value.Detach();
    }
  }

  void DetachAll(List<EquipSlot.Slot> slots_to_detach) {
    foreach (EquipSlot.Slot slot in slots_to_detach) {
      EquipSlot x;

      slots.TryGetValue(slot, out x);
      if (x != null) {
        x.Detach();
      }
    }
  }

  void Attach(EquipSlot.Slot target_slot, TacticalItem item) {
    EquipSlot slot;
    slots.TryGetValue(target_slot, out slot);
    slot.Assign(item);
  }

  public override List<EquipSlot.Slot> MapAnatomySlot() {
    List<EquipSlot.Slot> rets = new List<EquipSlot.Slot>() {
      EquipSlot.Slot.hands
    };

    slots.Add(EquipSlot.Slot.hands, equip_hand);

    switch (side) {
      case Side.l: 
        rets.Add(EquipSlot.Slot.arm_l);
        slots.Add(EquipSlot.Slot.arm_l, equip_arm);
        break;
      case Side.r: 
        rets.Add(EquipSlot.Slot.arm_r);
        rets.Add(EquipSlot.Slot.arm_2h);
        slots.Add(EquipSlot.Slot.arm_r, equip_arm);
        slots.Add(EquipSlot.Slot.arm_2h, equip_arm);
        break;
      default:
        Debug.Log("Undefined side: " + side);
        break;
    }

    return rets;
  }
}
