using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;


public class s101 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("a bracelet", () =>
        {
            GoCalled00();
        });

        keywords.Add("a ring", () =>
        {
            GoCalled01();
        });

        keywords.Add("a plate", () =>
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
        Debug.Log("Excellent. She wanted a bracelet.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score += 5;
        txts101.textDisplay += "Excellent. She wanted a bracelet.";
    }

    void GoCalled01()
    {
        Debug.Log("Opps!You are wrong. She wanted a bracelet.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts101.textDisplay += "Opps! You are wrong. She wanted a bracelet.";
    }

    void GoCalled02()
    {
        Debug.Log("Opps!You are wrong. She wanted a bracelet.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts101.textDisplay += "Opps! You are wrong. She wanted a bracelet.";
    }
}
