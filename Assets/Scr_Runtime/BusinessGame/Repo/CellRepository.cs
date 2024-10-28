using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace TD {

    public class CellRepository {

        Dictionary<int, CellEntity> all;

        CellEntity[] temArray;


        public CellRepository() {
            all = new Dictionary<int, CellEntity>();
            temArray = new CellEntity[100];
        }

        public void Add(CellEntity entity) {
            all.Add(entity.id, entity);
        }


        public void Remove(CellEntity entity) {
            all.Remove(entity.id);
        }

        public int TakeAll(out CellEntity[] array) {
            if (all.Count > temArray.Length) {
                temArray = new CellEntity[all.Count * 2];
            }
            all.Values.CopyTo(temArray, 0);
            array = temArray;

            return all.Count;
        }


    }
}