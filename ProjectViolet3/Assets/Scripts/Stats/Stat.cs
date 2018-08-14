using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat {
  public int hp;
  public int max_hp;
  public float mass;
  
  Stat(int _hp) {
    SetMaxHp(_hp);
    SetHp(_hp);
  }

  Stat(int _hp, int _hp_remaining) {
    SetMaxHp(_hp);
    SetHp(_hp);
  }

  public void AdjustHP(int x) {

  }

  public void SetHP(int x) {

  }

  public void AdjustMaxHP(int x) {

  }

  public void SetMass(float _mass) {

  }

  public void AdjustMass(float _mass) {

  }

  public void SetMass(float _mass) {
    mass = _mass;
  }

  protected void SetMaxHp(int _max_hp) {
    max_hp = _max_hp;
  }

  protected void SetHp(int _hp) {
    hp = _hp;
  }
}
