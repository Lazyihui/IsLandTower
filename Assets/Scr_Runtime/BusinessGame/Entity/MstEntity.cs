using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MstEntity : MonoBehaviour {

    public int id;

    public int hp;

    public int maxHp;


    public void Ctor() {
        hp = 3;
        maxHp = 3;
    }

    public void TearDown() {
        GameObject.Destroy(this.gameObject);
    }

}