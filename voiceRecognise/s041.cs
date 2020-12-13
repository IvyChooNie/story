using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class s041 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("spray water to the ant", () =>
        {
            GoCalled00();
        });

        keywords.Add("step on the ant", () =>
        {
            GoCalled01();
        });

        keywords.Add("smash the ant", () =>
        {
            GoCalled02();
        });

        keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizerOnPhraseRecognizer;
        keywordRecognizer.Start();
    }

    void KeywordRecognizerOnPhraseRecognizer(PhraseRecognizedEventArgs args)
    {
        System.Action keywordAction;

        if (keywords.TryGetValue(args.text, out keywordAction))
        {
            keywordAction.Invoke();
        }

    }

    void GoCalled00()
    {
        Debug.Log("Excellent. The elephant sprayed water to the ant.");
        //this.transform.Translate(Vector3.up * 10.0f);
       txts041.textDisplay += "Excellent. The elephant sprayed water to the ant.";
        ScoreBoard.Score += 5;
    }

    void GoCalled01()
    {
        Debug.Log("Opps!You are wrong. The elephant sprayed water to the ant.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts041.textDisplay += "Opps! You are wrong. The elephant sprayed water to the ant.";
    }

    void GoCalled02()
    {
        Debug.Log("Opps!You are wrong. The elephant sprayed water to the ant.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts041.textDisplay += "Opps! You are wrong. The elephant sprayed water to the ant.";
    }
}
