using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TD {


    public class GameContext {
        // inInject
        public Camera mainCamera;

        // Game
        public GameEntity gameEntity;

        // repos
        public TowerRepository towerRepository;

        public MapRepository mapRepository;

        public MstRepository mstRepository;
        public CellRepository cellRepository;


        // Core

        public AssetsCore assetsCore;

        public TemplateCore templateCore;

        public GameContext() {
            // Game
            gameEntity = new GameEntity();

            // repos
            towerRepository = new TowerRepository();
            mapRepository = new MapRepository();
            mstRepository = new MstRepository();
            cellRepository = new CellRepository();

            // Core
            assetsCore = new AssetsCore();
            templateCore = new TemplateCore();
        }

        public void Inject(Transform cellRoot,Camera camera) {
            gameEntity.Inject(cellRoot);
            mainCamera = camera;
        }

    }
}
