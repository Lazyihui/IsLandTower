using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;


namespace TD.TemplateInternal {

    public class TemplateContext {

        public Dictionary<int, TowerTM> towers;

        public AsyncOperationHandle towerPtr;

        public TemplateContext() {
            towers = new Dictionary<int, TowerTM>();
        }
    }
}