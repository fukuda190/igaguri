//元のからターゲットor地面に当たったら消滅かつターゲットに当たったらスコア増やすコード追加

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriController : MonoBehaviour {

    public int score;
    public GameObject scoreText;

	public void Shoot(Vector3 dir) {
		GetComponent<Rigidbody>().AddForce(dir);
	}

	void OnCollisionEnter(Collision other) {

        if (other.gameObject.tag == "target")
        {
            GetComponent<ParticleSystem>().Play();
            scoreText.GetComponent<ScoreManager>().score += score;
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "Terrain")
        {
            Destroy(this.gameObject);
        }
	}

	void Start() {
        scoreText = GameObject.Find("Score");
        //score = 1;
		// Shoot(new Vector3(0, 200, 2000));
	}
}