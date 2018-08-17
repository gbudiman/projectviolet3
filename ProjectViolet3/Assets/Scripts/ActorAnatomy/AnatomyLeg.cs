using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnatomyLeg : ActorAnatomy {
  EquipLeg equip_leg;
  EquipFoot equip_foot;
  public enum Slot { leg, foot };
  public enum Side { l, r };
  public Side side;

  public AnatomyLeg(Side _side): base() {
    side = _side;
    slots = new Dictionary<EquipSlot.Slot, EquipSlot>();
    equip_leg = new EquipLeg();
    equip_foot = new EquipFoot();
  }

  public override List<EquipSlot.Slot> MapAnatomySlot() {
    List<EquipSlot.Slot> rets = new List<EquipSlot.Slot>() {
      EquipSlot.Slot.legs, EquipSlot.Slot.feet
    };

    slots.Add(EquipSlot.Slot.legs, equip_leg);
    slots.Add(EquipSlot.Slot.feet, equip_foot);

    return rets;
  }

  public override void Equip(TacticalItem item) {
    
  }

  public override void UnEquip() {
    throw new System.NotImplementedException();
  }

  public override void UnEquip(EquipSlot.Slot slot) {
    throw new System.NotImplementedException();
  }
}
