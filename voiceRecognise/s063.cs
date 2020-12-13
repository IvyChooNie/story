using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class s063 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("it fight with the tiger", () =>
        {
            GoCalled00();
        });

        keywords.Add("it did not had food to eat", () =>
        {
            GoCalled01();
        });

        keywords.Add("it caught by the hunter", () =>
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
        Debug.Log("Excellent. The mother of the wolf die because it fighted with the tiger.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score += 5;
        txts063.textDisplay += "Excellent. The mother of the wolf die because it fighted with the tiger.";
    }

    void GoCalled01()
    {
        Debug.Log("Opps!You are wrong. The mother of the wolf die because it fighted with the tiger.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts063.textDisplay += "Opps!You are wrong. The mother of the wolf die because it fighted with the tiger.";
    }

    void GoCalled02()
    {
        Debug.Log("Opps!You are wrong. The mother of the wolf die because it fighted with the tiger.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts063.textDisplay += "Opps!You are wrong. The mother of the wolf die because it fighted with the tiger.";
    }
}
