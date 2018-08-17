using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActEquip : TacticalAction {
  public ActEquip(TacticalActor actor): base(actor) {
    base.SetName("Equip Item");
    base.is_available = true;
  }

  public void Act(TacticalItem item, EquipSlot.Slot slot) {
    _Act(item, slot);
  }

  public void Act(TacticalItem item) {
    EquipSlot.Slot slot = item.target_slot[0];
    _Act(item, slot);
  }

  private void _Act(TacticalItem item, EquipSlot.Slot slot) {
    ActorAnatomy anatomy;
    actor.anatomy_map.TryGetValue(slot, out anatomy);

    switch (slot) {
      case EquipSlot.Slot.arm_2h:
        anatomy.Equip(item);
        ActorAnatomy other_side;
        actor.anatomy_map.TryGetValue(EquipSlot.Slot.arm_l, out other_side);
        ((AnatomyArm)other_side).EquipWithoutDetach(item, EquipSlot.Slot.arm_l);
        break;
    }

  }
}
