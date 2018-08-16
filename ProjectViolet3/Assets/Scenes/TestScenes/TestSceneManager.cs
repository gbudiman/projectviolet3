using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSceneManager : MonoBehaviour {
  TacticalActor tactical_actor_prefab;
  TacticalEquipment tactical_equipment_prefab;

	// Use this for initialization
	void Start () {
    tactical_actor_prefab = Resources.Load<TacticalActor>("ActorPrefab");
    tactical_equipment_prefab = Resources.Load<TacticalEquipment>("ItemPrefab");

    TacticalActor actor_0 = Instantiate(tactical_actor_prefab);
    TacticalEquipment item_2h = Instantiate(tactical_equipment_prefab);

    actor_0.Spawn();
    item_2h.Spawn(EquipSlot.Slot.arm_2h);
    TestEquip2H(actor_0, item_2h);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

  void TestEquip2H(TacticalActor actor, TacticalEquipment item) {
    TacticalAction action;
    actor.actions.TryGetValue("Equip Item", out action);
    ((ActEquip)action).Act(item, EquipSlot.Slot.arm_l);
  }
}
