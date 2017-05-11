using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public GameObject imgMoney;
	public Text scoreText;
	public float scoreCount;
	//public float pointsPerTouch;

	void Start () {
		//verify if value already exist in PlayerPrefs
	}

	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			scoreCount++;
			Vector3 p = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 10f));
			Instantiate (imgMoney, new Vector3 (p.x, p.y, 0f), Quaternion.identity);
			Destroy (this.imgMoney, 0.5f);

		}

		scoreText.text = " " + Mathf.Round(scoreCount) + " ";
	}
}
