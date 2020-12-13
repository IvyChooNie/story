using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change : MonoBehaviour
{

    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(changeColor());
    }

    // Update is called once per frame
    public IEnumerator changeColor()
    {
        yield return new WaitForSeconds(10f);
        image.color = Color.blue;
    }
}
