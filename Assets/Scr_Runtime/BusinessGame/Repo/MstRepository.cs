using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace TD {

    public class MstRepository {

        Dictionary<int, MstEntity> all;

        MstEntity[] temArray;


        public MstRepository() {
            all = new Dictionary<int, MstEntity>();
            temArray = new MstEntity[100];
        }

        public void Add(MstEntity entity) {
            all.Add(entity.id, entity);
        }


        public void Remove(MstEntity entity) {
            all.Remove(entity.id);
        }

        public int TakeAll(out MstEntity[] array) {
            if (all.Count > temArray.Length) {
                temArray = new MstEntity[all.Count * 2];
            }
            all.Values.CopyTo(temArray, 0);
            array = temArray;

            return all.Count;
        }


    }
}