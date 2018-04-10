//Igaguri自然消失スクリプト：IgaguriのPrefabにアタッチする

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriDestroy : MonoBehaviour {

    float time;
    float destroyTime;

	// Use this for initialization
	void Start () {

        destroyTime = 5f;

	}
	
	// Update is called once per frame
	void Update () {

        time += Time.deltaTime;

        if (time >= destroyTime)
        {

            Destroy(this.gameObject);

        }
		
	}
}
