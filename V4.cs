using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class V4 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("The baby is sleeping", () =>
        {
            GoCalled09();
        });

        keywords.Add("The baby is crying", () =>
        {
            GoCalled10();
        });

        keywords.Add("The baby is running", () =>
        {
            GoCalled15();
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

    void GoCalled09()
    {
        Debug.Log("Excellent. The baby is sleeping.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score += 2;
    }

    void GoCalled10()
    {
        Debug.Log("Opps!You are wrong.The baby is sleeping.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 2;
    }

    void GoCalled15()
    {
        Debug.Log("Opps!You are wrong.The baby is sleeping.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 2;
    }
}
