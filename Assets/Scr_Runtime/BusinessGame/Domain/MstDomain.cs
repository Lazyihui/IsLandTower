using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace TD {

    public static class MstDomain {

        public static MstEntity Spawn(GameContext ctx) {

            GameObject prefab = ctx.assetsCore.Entity_GetMst();

            if (prefab == null) {
                Debug.LogError("Mst prefab not found");
                return null;
            }

            GameObject go = GameObject.Instantiate(prefab);
            MstEntity entity = go.GetComponent<MstEntity>();

            entity.Ctor();
            
            ctx.mstRepository.Add(entity);

            return entity;
        }

        public static void UnSpawn(GameContext ctx, MstEntity entity) {
            entity.TearDown();
            ctx.mstRepository.Remove(entity);
        }
    }
}