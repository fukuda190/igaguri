using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpown : MonoBehaviour {

    public GameObject TragetPrefab;

	// Use this for initialization
	void Start () {
        
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void RandomSpown()
    {
        float x = Random.Range(0.0f, 10.0f);
        float y = 0;
        float z = Random.Range(0.0f, 10.0f);
        GameObject Obj = Instantiate(TragetPrefab, new Vector3(x, y, z), Quaternion.identity) as GameObject;
    }

    public void Hakai()
    {
        GameObject.Destroy(gameObject);
    }
}
