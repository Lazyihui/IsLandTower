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
        }


        public void UnLoadAll() {
            if (ctx.entitiesHandle.IsValid()) {
                Addressables.Release(ctx.entitiesHandle);
            }
        }


    }
}