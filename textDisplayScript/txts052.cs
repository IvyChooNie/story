using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class txts052 : MonoBehaviour
{
    public static string textDisplay = "";
    Text txt;

    void Start()
    {
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = textDisplay;
    }
}
