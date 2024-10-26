using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TD {

    public static class MapDomain {
        public static MapEntity Spawn(GameContext ctx) {

            // 1.得到地图预制体
            GameObject prefab = ctx.assetsCore.Entity_GetMap();
            if(prefab == null) {
                Debug.LogError("Map prefab not found");
                return null;
            }

            GameObject go = GameObject.Instantiate(prefab);
            MapEntity entity = go.GetComponent<MapEntity>();

            entity.Ctor();

            ctx.mapRepository.Add(entity);

            // 2.得到底下的组件
            GameObject girdPrefab = ctx.assetsCore.Entity_GetMapElement();
            MapGridElement gird = GameObject.Instantiate(girdPrefab).GetComponent<MapGridElement>();

            entity.Inject(gird);

            return entity;

        }
    }
}