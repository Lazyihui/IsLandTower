using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using TD.AssetsInternal;

namespace TD {


    public class AssetsCore {
        AssetsContext ctx;


        public AssetsCore() {

            ctx = new AssetsContext();
        }


        public async Task LoadAll() {
            {
                AssetLabelReference labelReference = new AssetLabelReference();

                labelReference.labelString = "Entity";
                var handle = Addressables.LoadAssetsAsync<GameObject>(labelReference, null);

                var all = await handle.Task;
                foreach (var item in all) {
                    ctx.entities.Add(item.name, item);
                }

                ctx.entitiesHandle = handle;
            }

            {
                AssetLabelReference labelReference = new AssetLabelReference();
                labelReference.labelString = "Panel";
                var handle = Addressables.LoadAssetsAsync<GameObject>(labelReference, null);

                var all = await handle.Task;

                foreach (var item in all) {
                    ctx.panels.Add(item.name, item);
                }

                ctx.panelsHandle = handle;
            }
        }


        public void UnLoadAll() {
            if (ctx.entitiesHandle.IsValid()) {
                Addressables.Release(ctx.entitiesHandle);
            }
            if (ctx.panelsHandle.IsValid()) {
                Addressables.Release(ctx.panelsHandle);
            }
        }


        public GameObject Entity_GetTower() {
            ctx.entities.TryGetValue("Entity_Tower", out GameObject tower);
            return tower;
        }

        public GameObject Entity_GetMap() {
            ctx.entities.TryGetValue("Entity_Map", out GameObject map);
            return map;
        }

        public GameObject Entity_GetMapElement() {
            ctx.entities.TryGetValue("Grid_1", out GameObject mapElement);
            return mapElement;
        }


        public GameObject Entity_GetMst() {
            ctx.entities.TryGetValue("Entity_Mst", out GameObject mst);
            return mst;
        }

        public GameObject Entity_GetCell() {
            ctx.entities.TryGetValue("Entity_Cell", out GameObject cell);
            return cell;
        }

        public GameObject Entity_GetCellElement() {
            ctx.entities.TryGetValue("CellElement", out GameObject enemy);
            return enemy;
        }

        public GameObject Panel_GetTower() {
            ctx.panels.TryGetValue("Panel_Tower", out GameObject tower);
            return tower;
        }
    }
}