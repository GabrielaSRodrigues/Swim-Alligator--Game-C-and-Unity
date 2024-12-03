using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animajaca : MonoBehaviour {

	Animator anim;

	void Start () {
		anim = gameObject.GetComponent<Animator> ();
	}

	void Update () {

		if (Input.GetKey (KeyCode.Space)) {
			anim.SetBool ("Parado", false);
			anim.SetBool ("Anda", true);
		} else {
			anim.SetBool ("Anda", false);
			anim.SetBool ("Parado", true);
		}
	}
}
