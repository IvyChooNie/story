using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;


public class s072 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("neighbouring villages", () =>
        {
            GoCalled00();
        });

        keywords.Add("big city", () =>
        {
            GoCalled01();
        });

        keywords.Add("supermarket", () =>
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
        Debug.Log("Excellent. The answer is neighbouring villages.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score += 5;
        txts072.textDisplay += "Excellent. The answer is neighbouring villages.";
    }

    void GoCalled01()
    {
        Debug.Log("Opps!You are wrong. The answer is neighbouring villages.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts072.textDisplay += "Opps! You are wrong. The answer is neighbouring villages.";
    }

    void GoCalled02()
    {
        Debug.Log("Opps!You are wrong. The answer is neighbouring villages.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts072.textDisplay += "Opps! You are wrong. The answer is neighbouring villages.";
    }
}
