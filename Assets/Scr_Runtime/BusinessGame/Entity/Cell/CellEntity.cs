using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TD {


    public class CellEntity : MonoBehaviour {

        [SerializeField] GameObject select;
        [SerializeField] GameObject noSelect;
        [SerializeField] GameObject PreSelect;

        [SerializeField] GameObject towerSprite;

        public CellState state;

        public int id;

        public bool hasTower;


        public void Ctor() {
            state = CellState.Select;
            hasTower = false;
        }


        public void SetPos(Vector3 pos) {
            transform.position = pos;
        }


        public void SetState() {

            if (state == CellState.NoSelect) {

                select.SetActive(false);
                noSelect.SetActive(true);
                PreSelect.SetActive(false);

            } else if (state == CellState.Select) {

                select.SetActive(true);
                noSelect.SetActive(false);
                PreSelect.SetActive(false);

            } else if (state == CellState.PreSelect) {

                select.SetActive(false);
                noSelect.SetActive(false);
                PreSelect.SetActive(true);
            } else if (state == CellState.Tower) {
                noSelect.SetActive(false);
                select.SetActive(false);
                PreSelect.SetActive(false);
                
                towerSprite.SetActive(true);
            }

        }


    }
}