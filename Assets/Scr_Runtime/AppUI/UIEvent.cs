using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TD {
    public class UIEvent {

        public Action<int> OnClickToewr1Handler;

        public void OnClickToewr1Handle(int a) {

            if (OnClickToewr1Handler != null) {
                OnClickToewr1Handler.Invoke(a);
            }
        }

        public Action<int> OnClickToewr2handler;

        public void OnClickToewr2Handle(int a) {

            if (OnClickToewr2handler != null) {
                OnClickToewr2handler.Invoke(a);
            }
        }


        public Action<int> OnClickToewr3handler;

        public void OnClickToewr3Handle(int a) {

            if (OnClickToewr3handler != null) {
                OnClickToewr3handler.Invoke(a);
            }
        }

    }
}



