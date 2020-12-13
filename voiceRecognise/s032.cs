using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class s032 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("from the duck", () =>
        {
            GoCalled00();
        });

        keywords.Add("from the fish", () =>
        {
            GoCalled01();
        });

        keywords.Add("from the king", () =>
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
        Debug.Log("Excellent. The servant get the ring from the duck.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score += 5;
        txts032.textDisplay += "Excellent. The servant get the ring from the duck.";
    }

    void GoCalled01()
    {
        Debug.Log("Opps!You are wrong.The servant get the ring from the duck.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts032.textDisplay += "Opps!You are wrong. The servant get the ring from the duck.";
    }

    void GoCalled02()
    {
        Debug.Log("Opps!You are wrong.The servant get the ring from the duck.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts032.textDisplay += "Opps!You are wrong. The servant get the ring from the duck.";
    }
}
