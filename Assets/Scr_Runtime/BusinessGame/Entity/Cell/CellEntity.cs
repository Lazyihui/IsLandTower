using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TD {


    public class CellEntity : MonoBehaviour {

        [SerializeField] GameObject select;
        [SerializeField] GameObject noSelect;
        [SerializeField] GameObject PreSelect;

        public CellState state;

        public int id;

        public void Ctor() {
            state = CellState.NoSelect;
        }

        public void SetPos(Vector3 pos) {
            transform.position = pos;
        }


        public void SetState() {

            switch (state) {
                case CellState.NoSelect:
                    select.SetActive(false);
                    noSelect.SetActive(true);
                    PreSelect.SetActive(false);
                    break;
                case CellState.Select:
                    select.SetActive(true);
                    noSelect.SetActive(false);
                    PreSelect.SetActive(false);
                    break;
                case CellState.PreSelect:
                    select.SetActive(false);
                    noSelect.SetActive(false);
                    PreSelect.SetActive(true);
                    break;
            }
        }


    }
}