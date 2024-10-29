using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace TD {

    public static class TowerDomain {

        public static TowerEntity Spawn(GameContext ctx, int typeID, Vector3 pos) {

            TowerTM tm = ctx.templateCore.Get_TMTower(typeID);

            GameObject prefab = ctx.assetsCore.Entity_GetTower();

            if (prefab == null) {
                Debug.LogError("Tower prefab not found");
                return null;
            }

            GameObject go = GameObject.Instantiate(prefab);
            TowerEntity entity = go.GetComponent<TowerEntity>();

            entity.Ctor();
            entity.SetPos(pos);

            entity.id = ctx.gameEntity.towerIDRecord++;
            entity.typeID = tm.typeID;
            entity.SetSprite(tm.sprite);

            ctx.towerRepository.Add(entity);

            return entity;
        }

        public static void Attack(GameContext ctx, TowerEntity tower, float dt) {

            if (tower == null) {
                return;
            }

            tower.attackTime += dt;

            if (tower.attackTime >= tower.attackInterval) {

                int len = ctx.mstRepository.TakeAll(out MstEntity[] msts);

                for (int i = 0; i < len; i++) {
                    MstEntity mst = msts[i];
                    if (mst == null) {
                        continue;
                    }

                    float dis = Vector3.Distance(tower.transform.position, mst.transform.position);
                    Debug.Log(mst.transform.position);
                    Debug.DrawLine(tower.transform.position, mst.transform.position, Color.red);
                    Debug.Log("dis:" + dis);
                    if (dis <= tower.attackRange) {

                        // 攻击 发射子弹
                        mst.hp -= tower.attackPower;
                        tower.attackTime = 0;
                        Debug.Log("mst hp:" + mst.hp);
                        if (mst.hp <= 0) {
                            MstDomain.UnSpawn(ctx, mst);
                        }
                    }
                }
            }


        }

    }
}