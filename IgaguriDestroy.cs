﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriDestroy : MonoBehaviour {

    float time;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

        time += Time.deltaTime;

        if (time >= 5)
        {

            Destroy(this.gameObject);

        }
		
	}
}
