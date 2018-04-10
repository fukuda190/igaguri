//target移動スクリプト：taegetにアタッチする

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetMove : MonoBehaviour {

    public float moveSpeed;
    public float moveRange;

	// Use this for initialization
	void Start () {

        //moveSpeed = 1;
        //moveRange = 5;

	}
	
	// Update is called once per frame
	void Update () {

        this.transform.position = new Vector3(Mathf.Sin(Time.time * moveSpeed) * moveRange, 0f, 0f);
		
	}
}
