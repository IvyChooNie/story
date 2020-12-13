using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class s092 : MonoBehaviour
{

    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("blew the air", () =>
        {
            GoCalled00();
        });

        keywords.Add("kick the house", () =>
        {
            GoCalled01();
        });

        keywords.Add("burn the house", () =>
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
        Debug.Log("Excellent. The wolf blew air to their house.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score += 5;
        txts092.textDisplay += "Excellent. The wolf blew air to their house.";
    }

    void GoCalled01()
    {
        Debug.Log("Opps!You are wrong. The wolf blew air to their house.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts092.textDisplay += "Opps! You are wrong. The wolf blew air to their house.";
    }

    void GoCalled02()
    {
        Debug.Log("Opps!You are wrong. The wolf blew air to their house.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts092.textDisplay += "Opps! You are wrong. The wolf blew air to their house.";
    }
}
