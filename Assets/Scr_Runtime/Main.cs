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
            Camera camera = GameObject.Find("Main Camera").GetComponent<Camera>();

            ctx.Inject(cellRoot, camera);

            Action action = async () => {
                await ctx.assetsCore.LoadAll();
                await ctx.templateCore.LoadAll();
                
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
            float dt = Time.deltaTime;
            Game_Business.Tick(ctx, dt);
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
            ctx.templateCore.UnLoadAll();
        }







    }
}
