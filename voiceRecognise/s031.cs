using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class s031 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("can listen to the animals", () =>
        {
            GoCalled00();
        });

        keywords.Add("become rich", () =>
        {
            GoCalled01();
        });

        keywords.Add("become a king", () =>
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
        Debug.Log("Excellent. He can listen to the animals.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score += 5;
        txts031.textDisplay += "Excellent. He can listen to the animals.";
    }

    void GoCalled01()
    {
        Debug.Log("Opps!You are wrong. He can listen to the animals.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts031.textDisplay += "Opps!You are wrong. He can listen to the animals.";
    }

    void GoCalled02()
    {
        Debug.Log("Opps!You are wrong.He can listen to the animals.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts031.textDisplay += "Opps!You are wrong. He can listen to the animals.";
    }
}
