using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TD {


    public class CellEntity : MonoBehaviour {
        public int id;

        public void Ctor() {

        }

        public void SetPos(Vector3 pos) {
            transform.position = pos;
        }


    }
}