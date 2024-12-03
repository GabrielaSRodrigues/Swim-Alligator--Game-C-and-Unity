using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveobstaculos : MonoBehaviour {

	public float velocidade;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.position += new Vector3 (velocidade, 0, 0) * Time.deltaTime;

		if (transform.position.x < -30) {
			Destroy (gameObject);	
		}
	}
}
