using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class s013 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("bite", () =>
        {
            GoCalled00();
        });

        keywords.Add("twist", () =>
        {
            GoCalled01();
        });

        keywords.Add("pool", () =>
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
        Debug.Log("Excellent. The answer is bite.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score += 5;
        txts013.textDisplay += "Excellent. The answer is bite.";
    }

    void GoCalled01()
    {
        Debug.Log("Opps!You are wrong.The answer is pull.");
        //this.transform.Translate(Vector3.up * 10.0f);
        ScoreBoard.Score -= 5;
        txts013.textDisplay += "Opps!You are wrong The answer is bite.";
    }

    void GoCalled02()
    {
        Debug.Log("Opps!You are wrong.The answer is cut.");
        ScoreBoard.Score -= 5;
        txts013.textDisplay += "Opps!You are wrong The answer is bite.";
    }

    }
