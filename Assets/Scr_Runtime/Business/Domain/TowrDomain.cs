using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace TD {

    public static class TowerDomain {

        public static TowerEntity Spawn(GameContext ctx) {

            GameObject prefab = ctx.assetsCore.Entity_GetTower();

            if (prefab == null) {
                Debug.LogError("Tower prefab not found");
                return null;
            }

            GameObject go = GameObject.Instantiate(prefab);
            TowerEntity entity = go.GetComponent<TowerEntity>();

            entity.Ctor();
            
            ctx.towerRepository.Add(entity);

            return entity;
        }
    }
}