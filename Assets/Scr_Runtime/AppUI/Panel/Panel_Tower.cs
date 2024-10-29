using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Panel_Tower : MonoBehaviour {
    [SerializeField] Button tower1;

    [SerializeField] Button tower2;

    [SerializeField] Button tower3;


    public Action<int> OnTower1Click;

    public Action<int> OnTower2Click;

    public Action<int> OnTower3Click;

    public void Ctor() {
        tower1.onClick.AddListener(() => {
            if (OnTower1Click != null) {
                OnTower1Click.Invoke(TowerTypeConst.Tower1);
            }
        });

        tower2.onClick.AddListener(() => {
            if (OnTower2Click != null) {
                OnTower2Click.Invoke(TowerTypeConst.Tower2);
            }
        });

        tower3.onClick.AddListener(() => {
            if (OnTower3Click != null) {
                OnTower3Click.Invoke(TowerTypeConst.Tower3);
            }
        });
    }

    public void SetPos(Vector3 pos) {
        transform.position = pos;
    }

    public void Show() {
        gameObject.SetActive(true);
    }
    public void TearDown() {
        GameObject.Destroy(gameObject);
    }
}