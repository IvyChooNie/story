using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class storyToQue : MonoBehaviour
{

    public void load()
    {
        switch (this.gameObject.name)
        {
            case "next01":
                SceneManager.LoadScene("Demo_Scene");
                break;
        

       
            case "next02":
                SceneManager.LoadScene("story02-1");
                break;
        

        
            case "next03":
                SceneManager.LoadScene("story03-1");
                break;

            case "next04":
                SceneManager.LoadScene("story04-1");
                break;

            case "next05":
                SceneManager.LoadScene("story05-1");
                break;

            case "next06":
                SceneManager.LoadScene("story06-1");
                break;

            case "next07":
                SceneManager.LoadScene("story07-1");
                break;

            case "next08":
                SceneManager.LoadScene("story08-1");
                break;

            case "next09":
                SceneManager.LoadScene("story09-1");
                break;

            case "next10":
                SceneManager.LoadScene("story10-1");
                break;
        }


    }

}
