using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TD {

    public class MapEntity : MonoBehaviour {

        public int id;

        MapGridElement grid;

        public void Ctor() {

        }


        public void Inject(MapGridElement mapGridElement) {
            this.grid = mapGridElement;
        }

        public void TearDown() {
            GameObject.Destroy(this.gameObject);
            GameObject.Destroy(this.grid.gameObject);
        }
    }
}

