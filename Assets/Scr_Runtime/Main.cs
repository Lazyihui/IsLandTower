using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace TD {


    public class Main : MonoBehaviour {

        GameContext ctx;

        bool isInit = false;

        bool isTearDown = false;

        void Awake() {

            ctx = new GameContext();

            Action action = async () => {
                await ctx.assetsCore.LoadAll();
                isInit = true;

                // GameEnter;

                TowerEntity tower = TowerDomain.Spawn(ctx);
                tower.id = ctx.gameEntity.crystalID;

                MapDomain.Spawn(ctx);

                MstDomain.Spawn(ctx);

            };


            action.Invoke();

            Binding();

        }

        void Binding() {

        }

        void Update() {

        }

        void OnApplicationQuit() {
            TearDown();
        }

        void OnDestroy() {
            TearDown();
        }

        void TearDown() {
            if (isTearDown) {
                return;
            }

            isTearDown = true;

            ctx.assetsCore.UnLoadAll();
        }







    }
}
