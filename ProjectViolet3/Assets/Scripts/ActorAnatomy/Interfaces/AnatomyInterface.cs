using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAnatomyMappable {
  List<EquipSlot.Slot> MapAnatomySlot();
}

public interface IAnatomyEquippable {
  void Equip(TacticalItem item);
}