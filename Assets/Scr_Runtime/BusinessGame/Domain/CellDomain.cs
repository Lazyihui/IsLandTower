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

        public static void MouseSelect(GameContext ctx, CellEntity entity) {

            Ray mouseRay = ctx.mainCamera.ScreenPointToRay(Input.mousePosition);

            RaycastHit2D hitInfo;

            hitInfo = Physics2D.Raycast(mouseRay.origin, mouseRay.direction, Mathf.Infinity);

            if (hitInfo == false) {
                return;
            }

            if (hitInfo.collider.tag == "Cell") {


                entity.state = CellState.PreSelect;

                if (Input.GetMouseButtonDown(0)) {
                    entity.state = CellState.Select;

                    Debug.Log(entity.state);
                    // SetState(entity);
                }
            }

            // if (Physics2D.Raycast(mouseRay.origin, mouseRay.direction, Mathf.Infinity)) {

            //     Debug.Log("hit");
            // }

            // if (Physics2D.Raycast(mouseRay, out hitInfo)) {

            //     Debug.Log(hitInfo.collider.gameObject);
            //     Debug.Log(hitInfo.collider.gameObject);

            //     // if (hitInfo.collider.gameObject == entity.gameObject) {
            //     //     hasMouseSelect = true;
            //     // }

            // }

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        }


        public static void SetState(CellEntity entity) {
            entity.SetState();
        }

    }
}