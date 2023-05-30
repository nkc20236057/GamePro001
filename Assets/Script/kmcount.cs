using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kmcount : MonoBehaviour
{
    float meter;
    float meterText;

    void Update()
    {
        this.meter += Time.deltaTime * 60;
        this.meterText.GetComponent<Text>().text = this.meter.ToString("F1") + "km";
    }
}
