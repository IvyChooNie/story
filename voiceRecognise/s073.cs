using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class s073 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("river", () =>
        {
            GoCalled00();
        });

        keywords.Add("bathroom", () =>
        {
            GoCalled01();
        });

        keywords.Add("kitchen", () =>
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
        Debug.Log("Excellent. He get the water from the river.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score += 5;
        txts073.textDisplay += "Excellent. He get the water from the river";
    }

    void GoCalled01()
    {
        Debug.Log("Opps!You are wrong. He get the water from the river.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts073.textDisplay += "Opps! You are wrong. He get the water from the river";
    }

    void GoCalled02()
    {
        Debug.Log("Opps!You are wrong. He get the water from the river.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;

        txts073.textDisplay += "Opps! You are wrong. He get the water from the river";
    }
}
