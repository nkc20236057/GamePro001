using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;

public class GameDirector : MonoBehaviour
{
    GameObject hpgage;
    GameObject kmcount;
    void Start()
    {
        this.hpgage = GameObject.Find("hpGauge");
        this.kmcount = GameObject.Find("kmcount");
    }

    public void DecreaseHP()
    {
        this.hpgage.GetComponent<Image>().fillAmount -= 0.1f;
        if(hpgage == null)
        {
            SceneManager.LoadScene("TitleScene");
        }
        
    }

    public void CountKm()
    {
 
    }


}
