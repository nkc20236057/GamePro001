using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject hpGage;

    void Start()
    {
        this.hpGage = GameObject.Find("hpGauge");
    }
    public void DecreaseHP()
    {
        hpGage.GetComponent<Image>().fillAmount -= 0.1f;
    }
}

