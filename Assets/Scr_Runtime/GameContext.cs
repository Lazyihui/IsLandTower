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


        // Core

        public AssetsCore assetsCore;

        public GameContext() {
            // Game
            gameEntity = new GameEntity();

            // repos
            towerRepository = new TowerRepository();

            // Core
            assetsCore = new AssetsCore();
        }


    }
}
