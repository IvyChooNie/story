using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class quesButton : MonoBehaviour
{
    public void load()
    {
        switch (this.gameObject.name)
        {
            case "q1":
                SceneManager.LoadScene("Q1");
                break;
        }

        switch (this.gameObject.name)
        {
            case "q2":
                SceneManager.LoadScene("Q2");
                break;
        }

        switch (this.gameObject.name)
        {
            case "q3":
                SceneManager.LoadScene("Q3");
                break;
        }

        switch (this.gameObject.name)
        {
            case "q4":
                SceneManager.LoadScene("Q4");
                break;
        }

        switch (this.gameObject.name)
        {
            case "q5":
                SceneManager.LoadScene("Q5");
                break;
        }

        switch (this.gameObject.name)
        {
            case "q6":
                SceneManager.LoadScene("Q6");
                break;
        }

        switch (this.gameObject.name)
        {
            case "q7":
                SceneManager.LoadScene("Q7");
                break;
        }

        switch (this.gameObject.name)
        {
            case "q8":
                SceneManager.LoadScene("Q8");
                break;
        }

        switch (this.gameObject.name)
        {
            case "q9":
                SceneManager.LoadScene("Q9");
                break;
        }

        switch (this.gameObject.name)
        {
            case "q10":
                SceneManager.LoadScene("Q10");
                break;
        }

    }
}
