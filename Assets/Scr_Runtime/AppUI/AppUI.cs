using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TD {

    public class AppUI {

        public UIContext ctx;

        public UIEvent uIEvent;

        public AppUI() {
            ctx = new UIContext();
            uIEvent = new UIEvent();
        }


        public void Panel_Tower_Open(GameContext ctx) {
            Panel_Tower panel = ctx.appUI.ctx.panel_Tower;

            if (panel == null) {
                GameObject prefab = ctx.assetsCore.Panel_GetTower();
                if (prefab == null) {
                    Debug.LogError("Panel_Tower prefab is null");
                    return;
                }

                GameObject go = GameObject.Instantiate(prefab,ctx.screenCanvas.transform);
                panel = go.GetComponent<Panel_Tower>();

                panel.Ctor();

                ctx.appUI.ctx.panel_Tower = panel;
            }
            panel.Show();

        }


        public void Panel_Tower_Close(GameContext ctx) {
            Panel_Tower panel = ctx.appUI.ctx.panel_Tower;
            if (panel == null) {
                Debug.LogError("Panel_Tower is null");
                return;
            }
            panel.TearDown();
            ctx.appUI.ctx.panel_Tower = null;
        }

    }
}