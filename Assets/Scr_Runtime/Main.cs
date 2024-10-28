using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace TD {


    public class Main : MonoBehaviour {

        [SerializeField] Transform cellRoot;

        GameContext ctx;

        bool isInit = false;

        bool isTearDown = false;

        void Awake() {

            ctx = new GameContext();

            ctx.Inject(cellRoot);

            Action action = async () => {
                await ctx.assetsCore.LoadAll();
                isInit = true;

                // GameEnter;
                Game_Business.Enter(ctx);
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
