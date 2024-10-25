using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TD {


    public class GameContext {

        public TowerRepository towerRepository;



        // Core

        public AssetsCore assetsCore;

        public GameContext() {
            // repos
            towerRepository = new TowerRepository();

            // Core
            assetsCore = new AssetsCore();
        }


    }
}
