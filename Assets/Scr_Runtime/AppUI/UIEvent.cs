using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TD {
    public class UIEvent {

        public Action<int, Vector3> OnClickToewr1Handler;

        public void OnClickToewr1Handle(int a, Vector3 pos) {

            if (OnClickToewr1Handler != null) {
                OnClickToewr1Handler.Invoke(a, pos);
            }
        }

        public Action<int, Vector3> OnClickToewr2handler;

        public void OnClickToewr2Handle(int a, Vector3 pos) {

            if (OnClickToewr2handler != null) {
                OnClickToewr2handler.Invoke(a, pos);
            }
        }


        public Action<int, Vector3> OnClickToewr3handler;

        public void OnClickToewr3Handle(int a, Vector3 pos) {

            if (OnClickToewr3handler != null) {
                OnClickToewr3handler.Invoke(a, pos);
            }
        }

    }
}



