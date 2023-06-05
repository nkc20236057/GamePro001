using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class hpGauge : MonoBehaviour
{
    GameObject hpGage;
    private Image timer;
    private float countdown;

    void Start()
    {
        timer = GetComponent<Image>();
        this.hpGage = GameObject.Find("hpGauge");
    }

    void Update()
    {
        countdown = Time.time * -5.0f;

       
    }
}
