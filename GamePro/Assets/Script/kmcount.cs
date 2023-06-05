using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kmcount : MonoBehaviour
{
    private Text timer;
    private float keika;

    void Start()
    {
        timer = GetComponent<Text>();
        timer.text = "000000km";
    }

    void Update()
    {
        keika = Time.time * 40;
        timer.text = keika.ToString("000000km");
    }
}
