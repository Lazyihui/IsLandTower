using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TD {


    public class GameContext {

        // Game
        public GameEntity gameEntity;

        // repos
        public TowerRepository towerRepository;

        public MapRepository mapRepository;


        // Core

        public AssetsCore assetsCore;

        public GameContext() {
            // Game
            gameEntity = new GameEntity();

            // repos
            towerRepository = new TowerRepository();
            mapRepository = new MapRepository();

            // Core
            assetsCore = new AssetsCore();
        }


    }
}
