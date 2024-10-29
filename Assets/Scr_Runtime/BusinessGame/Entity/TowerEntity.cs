using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace TD {

    public class TowerEntity : MonoBehaviour {

        [SerializeField] SpriteRenderer sp;

        public int id;

        public int typeID;


        // 攻击

        public int attackPower;
        public float attackTime;

        public float attackInterval;

        public float attackRange;

        public void Ctor() {
            attackPower = 1;
            attackTime = 0;
            attackInterval = 2;
            attackRange = 5;

        }

        public void SetPos(Vector3 pos) {
            this.transform.position = pos;

        }
        public void SetSprite(Sprite sprite) {
            sp.sprite = sprite;
        }
    }

}