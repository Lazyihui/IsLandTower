using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TD{


public static class CellDomain{

    public static CellEntity Spawn(GameContext ctx){

        // 1.得到地图预制体
        GameObject prefab = ctx.assetsCore.Entity_GetCell();
        if(prefab == null) {
            Debug.LogError("Cell prefab not found");
            return null;
        }
        GameObject go = GameObject.Instantiate(prefab);

        GameObject cellPrefab = ctx.assetsCore.Entity_GetCellElement();
        CellEntity entity = GameObject.Instantiate(cellPrefab,go.transform).GetComponent<CellEntity>();


        entity.Ctor();

        ctx.cellRepository.Add(entity);

        return entity;

    }


}
}