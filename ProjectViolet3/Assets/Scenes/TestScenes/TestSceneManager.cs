using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class TestSceneManager : MonoBehaviour {
  TacticalActor tactical_actor_prefab;
  TacticalItem tactical_equipment_prefab;

	// Use this for initialization
	void Start () {
    tactical_actor_prefab = Resources.Load<TacticalActor>("ActorPrefab");
    tactical_equipment_prefab = Resources.Load<TacticalItem>("ItemPrefab");

    TacticalActor actor_0 = Instantiate(tactical_actor_prefab);
    TacticalItem item_2h = Instantiate(tactical_equipment_prefab);

    actor_0.Spawn();
    item_2h.Spawn("Gaebolg Spear", EquipSlot.Slot.arm_2h);
    TestEquip2H(actor_0, item_2h);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

  void TestEquip2H(TacticalActor actor, TacticalItem item) {
    TacticalAction action;
    actor.actions.TryGetValue("Equip Item", out action);
    ((ActEquip)action).Act(item);
    var q = actor.QueryAnatomy();

    Assert.IsTrue(q[EquipSlot.Slot.arm_2h] == item.name);
    Assert.IsTrue(q[EquipSlot.Slot.arm_l] == item.name);
    Assert.IsTrue(q[EquipSlot.Slot.arm_r] == item.name);
  }
}
