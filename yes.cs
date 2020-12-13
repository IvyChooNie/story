using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yes : MonoBehaviour
{
    public void id()
    {
        switch (this.gameObject.name)
        {
            case "s1":
                SceneManager.LoadScene("Story01");
                break;

                        case "s2":
                            SceneManager.LoadScene("Story02");
                            break;

            case "s3":
                SceneManager.LoadScene("Story03");
                break;

            case "s4":
                SceneManager.LoadScene("Story04");
                break;

            case "s5":
                SceneManager.LoadScene("Story05");
                break;

            case "s6":
                SceneManager.LoadScene("Story06");
                break;

            case "s7":
                SceneManager.LoadScene("Story07");
                break;

            case "s8":
                SceneManager.LoadScene("Story08");
                break;

            case "s9":
                SceneManager.LoadScene("Story09");
                break;

            case "s10":
                SceneManager.LoadScene("Story10");
                break;

            case "confirm":
                SceneManager.LoadScene("SampleScene");
                break;

            case "next01":
                SceneManager.LoadScene("Q1");
                break;
        }
    }
}
