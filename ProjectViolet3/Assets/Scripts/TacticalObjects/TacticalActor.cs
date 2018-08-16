using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TacticalActor : TacticalGameObject {
  ActorStat stat;
  int action_points;
  public Dictionary<string, TacticalAction> actions;
  Dictionary<ActorAnatomy.Anatomy, ActorAnatomy> anatomies;
  Dictionary<EquipSlot.Slot, ActorAnatomy> anatomy_map;

	// Use this for initialization
	void Start () {
    
	}
	
	// Update is called once per frame
	void Update () {
		
	}

  public void EngageMeleeAgainst(TacticalActor other_actor, TacticalAction action) {

  }

  public void Spawn() {
    PopulateAvailableActions();
    PopulateAnatomy();
  }

  void PopulateAnatomy() {
    anatomy_map = new Dictionary<EquipSlot.Slot, ActorAnatomy>();
    anatomies = new Dictionary<ActorAnatomy.Anatomy, ActorAnatomy>() {
      { ActorAnatomy.Anatomy.head, new AnatomyHead() },
      { ActorAnatomy.Anatomy.arm_l, new AnatomyArm() },
      { ActorAnatomy.Anatomy.arm_r, new AnatomyArm() },
      { ActorAnatomy.Anatomy.body, new AnatomyBody() },
      { ActorAnatomy.Anatomy.leg_l, new AnatomyLeg() },
      { ActorAnatomy.Anatomy.leg_r, new AnatomyLeg() }
    };

    foreach (KeyValuePair<ActorAnatomy.Anatomy, ActorAnatomy> pair in anatomies) {
      foreach (EquipSlot.Slot slot in pair.Value.MapAnatomySlot()) {
        anatomy_map.Add(slot, pair.Value);
      }
    }
  }

  void PopulateAvailableActions() {
    actions = new Dictionary<string, TacticalAction>();

    PopulateGenericActions();
    foreach (KeyValuePair<string, TacticalAction> t in actions) {
      Debug.Log(t.Value.name + ", " + t.Value.is_available);
    }
  }

  void PopulateGenericActions() {
    List<TacticalAction> generic_actions = new List<TacticalAction>();
    generic_actions.Add(new ActEquip(this));
    generic_actions.Add(new ActMove(this));
    generic_actions.Add(new ActWait(this));

    foreach (TacticalAction t in generic_actions) {
      AddToActionsDictionary(t);
    }

  }

  void AddToActionsDictionary(TacticalAction action) {
    actions.Add(action.name, action);
  }
  
}
