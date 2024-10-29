using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace TD {

    public class TowerEntity : MonoBehaviour {
        public int id;

        public int typeID;

        [SerializeField] SpriteRenderer sp;
        public void Ctor() {

        }

        public void SetPos(Vector3 pos){
            this.transform.position = pos;

        }
        public void SetSprite(Sprite sprite) {
            sp.sprite = sprite;
        }
    }

}