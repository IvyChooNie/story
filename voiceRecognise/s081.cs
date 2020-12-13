using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class s081 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("a donkey", () =>
        {
            GoCalled00();
        });

        keywords.Add("a dog", () =>
        {
            GoCalled01();
        });

        keywords.Add("chickens", () =>
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
        Debug.Log("Excellent. He bought a donkey.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score += 5;
        txts081.textDisplay += "Excellent. He bought a donkey.";
    }

    void GoCalled01()
    {
        Debug.Log("Opps!You are wrong. He bought a donkey.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts081.textDisplay += "Opps! You are wrong. He bought a donkey.";
    }

    void GoCalled02()
    {
        Debug.Log("Opps!You are wrong. He bought a donkey.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts081.textDisplay += "Opps! You are wrong. He bought a donkey.";
    
}
}
