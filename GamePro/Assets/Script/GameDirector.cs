using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject hpGage;
<<<<<<< HEAD
=======
    GameObject kmcount;

>>>>>>> origin/main

    void Start()
    {
        this.hpGage = GameObject.Find("hpGauge");
<<<<<<< HEAD
    }
    public void DecreaseHP()
    {
        hpGage.GetComponent<Image>().fillAmount -= 0.1f;
    }
=======
        this.kmcount = GameObject.Find("kmcount");
    }
   
    public void DecreaseHP()
        {
            hpGage.GetComponent<Image>().fillAmount -= 0.1f;
        }
    public void CountKM()
    {

    }

>>>>>>> origin/main
}

