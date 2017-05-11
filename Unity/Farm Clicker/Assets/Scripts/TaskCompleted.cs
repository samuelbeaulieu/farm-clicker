﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskCompleted : MonoBehaviour {

	public Transform LoadingBar;
	public Transform TextIndicator;
	[SerializeField] private float currentAmount;
	[SerializeField] private float speed;

	// Update is called once per frame
	void Update () {
		if (currentAmount < 100) {
			currentAmount += speed * Time.deltaTime;
			TextIndicator.GetComponent<Text>().text = ((int)currentAmount).ToString()+"%";
		} else {
			TextIndicator.GetComponent<Text>().text = "Done!";
		}

		LoadingBar.GetComponent<Image> ().fillAmount = currentAmount / 100;
	}
}
