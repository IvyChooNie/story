using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class s052 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("it had an owner", () =>
        {
            GoCalled00();
        });

        keywords.Add("it did not liked the wolf", () =>
        {
            GoCalled01();
        });

        keywords.Add("it was sick", () =>
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
        Debug.Log("Excellent. Because the dog had an owner.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score += 5;
        txts052.textDisplay += "Excellent. Because the dog had an owner.";
    }

    void GoCalled01()
    {
        Debug.Log("Opps!You are wrong. Because the dog had an owner.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts052.textDisplay += "Opps!You are wrong. Because the dog had an owner.";
    }

    void GoCalled02()
    {
        Debug.Log("Opps!You are wrong. Because the dog had an owner.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts052.textDisplay += "Opps!You are wrong. Because the dog had an owner.";
    }
}
