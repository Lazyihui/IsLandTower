using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameEntity {

    public Transform cellRoot;

    public int crystalID;

    public int cellIdRecord;

    public float restFixTime;


    public GameEntity() {
        crystalID = 0;
        restFixTime = 0;
    }

    public void Inject(Transform cellRoot) {
        this.cellRoot = cellRoot;
    }

}