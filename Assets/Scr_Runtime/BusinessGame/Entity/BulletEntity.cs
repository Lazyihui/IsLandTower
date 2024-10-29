using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TD {

    public class BulletEntity : MonoBehaviour {

        [SerializeField] SpriteRenderer sp;
        public int id;

        public int typeID;

        public int attackPower;


        public void Ctor() {

        }

        public void SetPos(Vector3 pos) {
            this.transform.position = pos;
        }


        public void SetColor(Color color) {
            sp.color = color;
        }

        public void TearDown() {
            GameObject.Destroy(this.gameObject);
        }
    }
}