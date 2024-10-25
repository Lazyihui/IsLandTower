using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;



namespace TD.AssetsInternal {

    public class AssetsContext {
        public Dictionary<string, GameObject> entities;


        public AsyncOperationHandle entitiesHandle;

        public AssetsContext() {
            entities = new Dictionary<string, GameObject>();
        }


    }
}