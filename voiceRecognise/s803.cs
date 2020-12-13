using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class s803 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("a sack", () =>
        {
            GoCalled00();
        });

        keywords.Add("a box", () =>
        {
            GoCalled01();
        });

        keywords.Add("a container", () =>
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
        Debug.Log("Excellent. They put him inside a sack .");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score += 5;
        txts083.textDisplay += "Excellent. They put him inside a sack.";
    }

    void GoCalled01()
    {
        Debug.Log("Opps!You are wrong. They put him inside a sack.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts083.textDisplay += "Opps! You are wrong. They put him inside a sack.";
    }

    void GoCalled02()
    {
        Debug.Log("Opps!You are wrong. They put him inside a sack.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts083.textDisplay += "Opps! You are wrong. They put him inside a sack.";
    }
}
