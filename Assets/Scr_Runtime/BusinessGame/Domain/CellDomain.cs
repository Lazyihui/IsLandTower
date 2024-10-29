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

            if (Physics2D.Raycast(mouseRay.origin, mouseRay.direction, Mathf.Infinity)) {

                if (hitInfo.collider.tag == "Cell") {

                    CellEntity cell = hitInfo.collider.GetComponent<CellEntity>();
                    if (cell.state == CellState.Select) return;

                    cell.state = CellState.PreSelect;

                    int len = ctx.cellRepository.TakeAll(out CellEntity[] cells);

                    for (int i = 0; i < len; i++) {
                        CellEntity exceptCell = cells[i];
                        if (exceptCell.id != cell.id && exceptCell.hasTower == false) {
                            exceptCell.state = CellState.NoSelect;
                        }
                    }


                    if (Input.GetMouseButtonDown(0)) {
                        cell.state = CellState.Select;
                        cell.hasTower = true;
                        if (ctx.appUI.ctx.panel_Tower == null) {

                            Vector3 pos = ctx.mainCamera.WorldToScreenPoint(cell.transform.position);

                            ctx.appUI.Panel_Tower_Open(ctx, pos);
                            
                        }else{
                            ctx.appUI.Panel_Tower_Close(ctx);
                        }
                    }




                }

            } else {
                if (entity.hasTower) {
                    return;
                }
                entity.state = CellState.NoSelect;
            }

        }


        public static void SetState(CellEntity entity) {
            entity.SetState();
        }

    }
}