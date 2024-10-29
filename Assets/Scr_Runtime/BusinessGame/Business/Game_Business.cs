using System;
using System.Collections.Generic;
using UnityEngine;



namespace TD {

    public static class Game_Business {

        public static void Enter(GameContext ctx) {

            TowerEntity tower = TowerDomain.Spawn(ctx);
            tower.id = ctx.gameEntity.crystalID;

            MapDomain.Spawn(ctx);

            MstDomain.Spawn(ctx);


            CellDomain.Spawn(ctx,ctx.gameEntity.cellRoot, new Vector3(-4.5f, 3, 0));
            CellDomain.Spawn(ctx,ctx.gameEntity.cellRoot, new Vector3(-2.5f, 3, 0));
            CellDomain.Spawn(ctx,ctx.gameEntity.cellRoot, new Vector3(-0.5f, 3, 0));
            CellDomain.Spawn(ctx,ctx.gameEntity.cellRoot, new Vector3(1.5f, 3, 0));
            CellDomain.Spawn(ctx,ctx.gameEntity.cellRoot, new Vector3(3.5f, 3, 0));
            CellDomain.Spawn(ctx,ctx.gameEntity.cellRoot, new Vector3(5.5f, 3, 0));




        }


        public static void Tick(GameContext ctx, float dt) {
            PreTick(ctx, dt);

            ref float restFixTime = ref ctx.gameEntity.restFixTime;

            restFixTime += dt;

            restFixTime += dt;
            const float FIX_INTERVAL = 0.020f;

            if (restFixTime <= FIX_INTERVAL) {

                LogicTick(ctx, restFixTime);

                restFixTime = 0;
            } else {
                while (restFixTime >= FIX_INTERVAL) {
                    LogicTick(ctx, FIX_INTERVAL);
                    restFixTime -= FIX_INTERVAL;
                }
            }

            LastTick(ctx, dt);
        }


        static void PreTick(GameContext ctx, float dt) {




        }

        static void LogicTick(GameContext ctx, float dt) {
            int lenCell = ctx.cellRepository.TakeAll(out CellEntity[] cells);

            for (int i = 0; i < lenCell; i++) {
                CellEntity cell = cells[i];
                CellDomain.MouseSelect(ctx, cell);
                CellDomain.SetState(cell);
            }
        }

        static void LastTick(GameContext ctx, float dt) {

        }
    }
}