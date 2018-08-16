using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TacticalActor : TacticalGameObject {
  ActorStat stat;
  int action_points;
  public Dictionary<string, TacticalAction> actions;
  Dictionary<ActorAnatomy.Anatomy, List<ActorAnatomy>> anatomies;

	// Use this for initialization
	void Start () {
    PopulateAvailableActions();
    PopulateAnatomy();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

  public void EngageMeleeAgainst(TacticalActor other_actor, TacticalAction action) {

  }

  void PopulateAnatomy() {
    anatomies = new Dictionary<ActorAnatomy.Anatomy, List<ActorAnatomy>>();

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
    generic_actions.Add(new ActEquip());
    generic_actions.Add(new ActMove());
    generic_actions.Add(new ActWait());

    foreach (TacticalAction t in generic_actions) {
      AddToActionsDictionary(t);
    }

  }

  void AddToActionsDictionary(TacticalAction action) {
    actions.Add(action.name, action);
  }
  
}
