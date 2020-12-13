using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class s071 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("selling milks", () =>
        {
            GoCalled00();
        });

        keywords.Add("selling cows", () =>
        {
            GoCalled01();
        });

        keywords.Add("selling eggs", () =>
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
        Debug.Log("Excellent. They earned their money through selling milks.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score += 5;
        txts071.textDisplay += "Excellent. They earned their money through selling milks.";
    }

    void GoCalled01()
    {
        Debug.Log("Opps!You are wrong. They earned their money through selling milks.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts071.textDisplay += "Opps! You are wrong. They earned their money through selling milks.";
    }

    void GoCalled02()
    {
        Debug.Log("Opps!You are wrong. They earned their money through selling milks.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts071.textDisplay += "Opps! You are wrong. They earned their money through selling milks.";
    }
}
