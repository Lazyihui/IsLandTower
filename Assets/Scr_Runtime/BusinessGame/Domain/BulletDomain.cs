using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TD {


    public static class BulletDomain {
        public static BulletEntity Spawn(GameContext ctx, int typeID) {
            GameObject prefab = ctx.assetsCore.Entity_GetBullet();
            if(prefab == null) {
                Debug.LogError("Bullet prefab not found");
                return null;
            }

            GameObject go = GameObject.Instantiate(prefab);
            BulletEntity entity = go.GetComponent<BulletEntity>();

            entity.Ctor();
            entity.id = ctx.gameEntity.bulletIDRecord++;

            ctx.bulletRepository.Add(entity);

            return entity;

        }
    }
}
