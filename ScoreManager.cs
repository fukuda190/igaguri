//"Score"って名前のテキスト作ってアタッチ

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public int score;
    int nowScore;

	// Use this for initialization
	void Start () {

        score = 0;
        nowScore = score;

	}
	
	// Update is called once per frame
	void Update () {
		
        if (score != nowScore)
        {
            GetComponent<Text>().text = "Score : " + score;
            nowScore = score;
        }

	}
}
