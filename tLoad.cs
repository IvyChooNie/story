using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tLoad : MonoBehaviour
{
    public void load()
    {
        switch (this.gameObject.name)
        {
            case "b01":
                SceneManager.LoadScene("T2");
                break;

            case "b02":
                SceneManager.LoadScene("T3");
                break;

            case "b03":
                SceneManager.LoadScene("T4");
                break;

            case "b04":
                SceneManager.LoadScene("T5");
                break;

            case "b05":
                SceneManager.LoadScene("T6");
                break;
        }
    }
}
