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
        public void SetSprite(Sprite sprite) {
            sp.sprite = sprite;
        }
    }

}