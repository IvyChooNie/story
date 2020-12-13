using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class s033 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("pick the golden apple", () =>
        {
            GoCalled00();
        });

        keywords.Add("pick the grains", () =>
        {
            GoCalled01();
        });

        keywords.Add("catch a whine snake", () =>
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
        Debug.Log("Excellent. The princess asked for a golden apple.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score += 5;
        txts033.textDisplay += "Excellent. The princess asked for a golden apple.";
    }

    void GoCalled01()
    {
        Debug.Log("Opps!You are wrong. The princess asked for a golden apple.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts033.textDisplay += "Opps! Yo are wrong. The princess asked for a golden apple.";
    }

    void GoCalled02()
    {
        Debug.Log("Opps!You are wrong.The answer is pick the golden apple.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts033.textDisplay += "Opps! Yo are wrong. The princess asked for a golden apple.";
    }
}
