using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TD {


    public class GameContext {
        // inInject
        public Camera mainCamera;
        public Canvas screenCanvas;

        // Game
        public GameEntity gameEntity;

        // repos
        public TowerRepository towerRepository;

        public MapRepository mapRepository;

        public MstRepository mstRepository;
        public CellRepository cellRepository;

        public BulletRepository bulletRepository;


        // Core

        public AssetsCore assetsCore;

        public TemplateCore templateCore;

        public AppUI appUI;

        public GameContext() {
            // Game
            gameEntity = new GameEntity();

            // repos
            towerRepository = new TowerRepository();
            mapRepository = new MapRepository();
            mstRepository = new MstRepository();
            cellRepository = new CellRepository();
            bulletRepository = new BulletRepository();

            // Core
            assetsCore = new AssetsCore();
            templateCore = new TemplateCore();
            appUI = new AppUI();
        }

        public void Inject(Transform cellRoot,Camera camera,Canvas screenCanvas) {
            gameEntity.Inject(cellRoot);
            mainCamera = camera;
            this.screenCanvas = screenCanvas;
        }

    }
}
