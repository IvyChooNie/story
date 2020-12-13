using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;


public class s093 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("fire the woods in the fireplace", () =>
        {
            GoCalled00();
        });

        keywords.Add("shout for help", () =>
        {
            GoCalled01();
        });

        keywords.Add("run away", () =>
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
        Debug.Log("Excellent. They fired the woods in the fireplace.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score += 5;
        txts093.textDisplay += "Excellent. They fired the woods in the fireplace.";
    }

    void GoCalled01()
    {
        Debug.Log("Opps!You are wrong. They fired the woods in the fireplace.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts093.textDisplay += "Opps! Yo are wrong. They fired the woods in the fireplace.";
    }

    void GoCalled02()
    {
        Debug.Log("Opps!You are wrong. They fired the woods in the fireplace.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts093.textDisplay += "Opps! Yo are wrong. They fired the woods in the fireplace.";
    }
}
