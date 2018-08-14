using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EquipSlot {
  int armor_point;
  string name;

  EquipSlot(string _name) {
    name = _name;
  }
}
