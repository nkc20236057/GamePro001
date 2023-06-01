using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class hpGauge : MonoBehaviour
{
    public GameObject hpGage;
    //カウントダウン
    private float countdown = 5.0f;

    void Update()
    {
        countdown -= Time.deltaTime;
    }
}
