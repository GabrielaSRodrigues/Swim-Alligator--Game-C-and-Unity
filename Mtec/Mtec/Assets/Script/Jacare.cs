using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Jacare : MonoBehaviour {

	public Vector2 forcapulo = new Vector2 (0, 100);
	public Rigidbody2D jacare;

	public Text txtpontos;
	public int score;

	//private int pontos; 

	void Start () {

		score = 0;

	}
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {
			jacare.velocity = Vector2.zero;
			jacare.AddForce (forcapulo);
		}
		//faz ele pular 

		Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0) {
			Morre ();
			//se sair da tela morre
		}
	}
	void OnCollisionEnter2D (Collision2D col){

		if (col.gameObject.tag == "Obstaculos") {
			PlayerPrefs.SetInt ("savepontos",score);

			if (score > PlayerPrefs.GetInt ("saverecord")) {
				PlayerPrefs.SetInt ("saverecord", score);
			}
			SceneManager.LoadScene ("Morreu");
		}
		//se colidir morre
	}

	void OnTriggerEnter2D (Collider2D col){

		if (col.gameObject.tag == "Obstaculos") {
			score++;
			txtpontos.text = "Score: " + score.ToString ();

			//pontos++;
			//txtpontos.text = pontos.ToString ();
		}
	}

	void Morre() {
		SceneManager.LoadScene ("Morreu");
	}
	//chama a cena de morreu
}

