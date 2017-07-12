using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSound : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (tag != "UnityChanTag")
        {
            // UnityChan 以外で衝突したら音を鳴らす
            GetComponent<AudioSource>().Play();
        }
    }
}
