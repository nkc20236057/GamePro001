using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject hpGage;
    GameObject kmcount;


    void Start()
    {
        this.hpGage = GameObject.Find("hpGauge");
        this.kmcount = GameObject.Find("kmcount");
    }
   
    public void DecreaseHP()
        {
            hpGage.GetComponent<Image>().fillAmount -= 0.1f;
        }
    public void CountKM()
    {

    }

}

