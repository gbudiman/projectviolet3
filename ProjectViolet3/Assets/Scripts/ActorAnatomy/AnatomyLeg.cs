using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnatomyLeg : ActorAnatomy {
  EquipLeg equip_leg;
  EquipFoot equip_foot;
  public enum Slot { leg, foot };
  public enum Side { l, r };
  public Side side;

  public AnatomyLeg() {
    
  }
}
