using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geraobstaculos : MonoBehaviour {

	public GameObject alga;
	public float temporespawn;
	private float tempoatual;

	void Update () {

		float _y = Random.Range (-4.18f, 1.81f);
		tempoatual += Time.deltaTime;

		if (tempoatual >= temporespawn) {
			tempoatual = 0;

			GameObject tempoPrefeb = Instantiate (alga) as GameObject;
			tempoPrefeb.transform.position = new Vector2 (transform.position.x, _y);
		}
	}
}
