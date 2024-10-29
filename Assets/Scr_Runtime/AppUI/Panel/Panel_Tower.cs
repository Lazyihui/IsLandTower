using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Panel_Tower : MonoBehaviour {
    [SerializeField] Button tower1;

    [SerializeField] Button tower2;

    [SerializeField] Button tower3;

    public void Ctor() {

    }

    public void Show() {
        gameObject.SetActive(true);
    }
    public void TearDown() {
        GameObject.Destroy(gameObject);
    }
}