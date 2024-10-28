using System;
using UnityEngine;



namespace TD {
    [CreateAssetMenu(fileName = "TM_Tower", menuName = "Template/TM_Tower")]
    public class TowerTM : ScriptableObject {

        public string towerName;
        public int typeID;
        public Sprite sprite;

    }
}
