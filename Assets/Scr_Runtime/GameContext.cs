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

        public MstRepository mstRepository;


        // Core

        public AssetsCore assetsCore;

        public GameContext() {
            // Game
            gameEntity = new GameEntity();

            // repos
            towerRepository = new TowerRepository();
            mapRepository = new MapRepository();
            mstRepository = new MstRepository();

            // Core
            assetsCore = new AssetsCore();
        }


    }
}
