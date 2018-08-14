using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipAccessory : EquipSlot {
  string granted_by;

  EquipAccessory(string _name, string _granted_by): base(_name) {
    granted_by = _granted_by;
  }

  public bool IsRemovedBy(string _conditional_name) {
    return base.name == _conditional_name;
  }
}
