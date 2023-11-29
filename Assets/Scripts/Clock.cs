using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    private Text clockText;
    // Start is called before the first frame update
    private void Awake()
    {
        clockText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        clockText.text = DateTime.Now.ToString("HH:mm:ss");
    }
}
