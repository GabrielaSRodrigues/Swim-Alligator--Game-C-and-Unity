using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontoserecord : MonoBehaviour {

	public Text txtpontos;
	public Text txtrecord;

	// Use this for initialization
	void Start () {

		txtpontos.text = "Score: " + PlayerPrefs.GetInt ("savepontos").ToString();
		txtrecord.text = "Record: " + PlayerPrefs.GetInt ("saverecord").ToString ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
