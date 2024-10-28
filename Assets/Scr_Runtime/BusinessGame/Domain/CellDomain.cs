using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TD {


    public static class CellDomain {

        public static CellEntity Spawn(GameContext ctx, Transform transform, Vector3 pos) {

            GameObject cellPrefab = ctx.assetsCore.Entity_GetCell();
            CellEntity entity = GameObject.Instantiate(cellPrefab, transform).GetComponent<CellEntity>();

            entity.Ctor();
            entity.SetPos(pos);

            entity.id = ctx.gameEntity.cellIdRecord++;

            ctx.cellRepository.Add(entity);

            return entity;

        }


    }
}