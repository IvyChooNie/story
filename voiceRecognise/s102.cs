using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class s102 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("he wanted the plate for free", () =>
        {
            GoCalled00();
        });

        keywords.Add("he did not wanted the broken plate", () =>
        {
            GoCalled01();
        });

        keywords.Add("he did not like the plate", () =>
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
        Debug.Log("Excellent. He wanted the plate for free.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score += 5;
        txts102.textDisplay += "Excellent. He wanted the plate for free.";
    }

    void GoCalled01()
    {
        Debug.Log("Opps!You are wrong. He wanted the plate for free.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts102.textDisplay += "Opps! You are wrong. He wanted the plate for free.";
    }

    void GoCalled02()
    {
        Debug.Log("Opps!You are wrong. He wanted the plate for free.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts102.textDisplay += "Opps! You are wrong. He wanted the plate for free.";
    }
}
