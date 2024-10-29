using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace TD {

    public static class TowerDomain {

        public static TowerEntity Spawn(GameContext ctx,int typeID,Vector3 pos) {

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
        
    }
}