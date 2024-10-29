using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using TD.TemplateInternal;

namespace TD {
    public class TemplateCore {
        TemplateContext ctx;

        public TemplateCore() {
            ctx = new TemplateContext();
        }

        public async Task LoadAll() {

            {
                AssetLabelReference labelReference = new AssetLabelReference();
                labelReference.labelString = "Tower";
                var handle = Addressables.LoadAssetsAsync<TowerTM>(labelReference, null);
                var all = await handle.Task;
                foreach (var item in all) {
                    ctx.towers.Add(item.typeID, item);
                }
                ctx.towerPtr = handle;
            }

        }

        public void UnLoadAll() {
            if (ctx.towerPtr.IsValid()) {
                Addressables.Release(ctx.towerPtr);
            }
        }

        public TowerTM Get_TMTower(int typeID) {
            ctx.towers.TryGetValue(typeID, out TowerTM tm);
            return tm;
        }
    }
}
