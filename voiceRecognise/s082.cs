using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class s082 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("the donkey will make coins", () =>
        {
            GoCalled00();
        });

        keywords.Add("the donkey is very clever", () =>
        {
            GoCalled01();
        });

        keywords.Add("the donkey is hardworking", () =>
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
        Debug.Log("Excellent. The shoemaker told them that the donkey will make coins.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score += 5;
        txts82.textDisplay += "Excellent. The shoemaker told them that the donkey will make coins.";
    }

    void GoCalled01()
    {
        Debug.Log("Opps!You are wrong. The shoemaker told them that the donkey will make coins.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts82.textDisplay += "Opps! You are wrong. The shoemaker told them that the donkey will make coins.";
    }

    void GoCalled02()
    {
        Debug.Log("Opps!You are wrong. The shoemaker told them that the donkey will make coins.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts82.textDisplay += "Opps! You are wrong. The shoemaker told them that the donkey will make coins.";
    }
}
