using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorStat : Stat {
  public int str;
  public int agi;
  public int vit;
  public int itl;
  public int dex;
  public int fai;

  public new enum Stats { hp, max_hp, mass, str, agi, vit, itl, dex, fai };

  public ActorStat(int _hp, int _max_hp, int _str, int _agi, int _vit, int _itl, int _dex, int _fai) : base(_max_hp, _hp) {
    str = _str;
    agi = _agi;
    vit = _vit;
    itl = _itl;
    dex = _dex;
    fai = _fai;
  }

  public void SetStat(Stat _stat, int x) {

  }

  public void AdjustStat(Stat _stat, int x) {

  }
}
