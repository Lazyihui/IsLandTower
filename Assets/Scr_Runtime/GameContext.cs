using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameContext {

    public TowerRepository towerRepository;

    public GameContext() {
        towerRepository = new TowerRepository();
    }


}
