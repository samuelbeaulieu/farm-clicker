﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public GameObject imgMoney;
	private GameObject spawnImgMoney;
	public Text scoreText;
	public float scoreCount;
	public float pointsPerSecond;
	private float RandomGoToPositionX;
	private float RandomGoToPositionY;
	public float pointsPerTouch;
	public float pointsPerTouch2;

	//Progress bar
	public Transform LoadingBar;
	public Transform TextIndicator;
	public Transform TextIndicatorResult;
	public float result1 = 1000;


	void Start () {
		//verify if value already exist in PlayerPrefs
		if (PlayerPrefs.HasKey ("Score")) {
			scoreCount = PlayerPrefs.GetFloat ("Score");
		} else {
			PlayerPrefs.SetFloat ("Score", scoreCount);
		}

		pointsPerTouch = 0;
		pointsPerTouch2 = 1;
	}

	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			scoreCount++;
			if (scoreCount >= 25 && scoreCount <= 49) {
				scoreCount += pointsPerTouch;
			}
			if (scoreCount >= 50 && scoreCount <= 99) {
				scoreCount += pointsPerTouch2;
			}

			Vector3 p = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 10f));
			var addTwoY = p.y + 2;
			var remTwoY = p.y - 2;
			var addTwoX = p.x + 2;
			var remTwoX = p.x - 2;
			RandomGoToPositionX = Random.Range(remTwoX, addTwoX);
			RandomGoToPositionY = Random.Range(remTwoY, addTwoY);


			spawnImgMoney = (GameObject)Instantiate (imgMoney, new Vector3 (p.x, p.y, 0f), Quaternion.identity);
			LeanTween.alpha (spawnImgMoney, 0f, 0.5f);
			LeanTween.moveLocalX (spawnImgMoney, RandomGoToPositionX, 0.5f);
			LeanTween.moveLocalY (spawnImgMoney, RandomGoToPositionY, 0.5f);
			Destroy (spawnImgMoney, 0.5f);

		}

		if (scoreCount >= 100) {
			scoreCount += pointsPerSecond * Time.deltaTime;
		}



		//Progress bar
		if (scoreCount < 1000) {
			TextIndicator.GetComponent<Text>().text = ((int)scoreCount).ToString();
			TextIndicatorResult.GetComponent<Text>().text = ((int)result1).ToString();
		} else {
			TextIndicator.GetComponent<Text>().text = "Done!";
		}

		LoadingBar.GetComponent<Image> ().fillAmount = scoreCount / result1;






		scoreText.text = " " + Mathf.Round(scoreCount) + " ";
		PlayerPrefs.SetFloat ("Score", scoreCount);
		PlayerPrefs.Save();

	}
}
