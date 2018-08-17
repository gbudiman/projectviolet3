using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActUnequip : TacticalAction {
  public ActUnequip(TacticalActor actor): base(actor) {
    base.SetName("Unequip Item");
    base.is_available = true;
  }

  public void Act(ActorAnatomy.Anatomy _anatomy) {
    ActorAnatomy anatomy;
    actor.anatomies.TryGetValue(_anatomy, out anatomy);
    anatomy.UnEquip();
  }

  public void Act(EquipSlot.Slot _slot) {
    ActorAnatomy anatomy;
    actor.anatomy_map.TryGetValue(_slot, out anatomy);
    anatomy.UnEquip(_slot);
  }
}
