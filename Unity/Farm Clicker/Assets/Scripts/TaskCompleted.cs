using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskCompleted : MonoBehaviour {

	public Transform LoadingBar;
	public Transform TextIndicator;
	[SerializeField] private float currentAmount;
	[SerializeField] private float speed;
	public Transform TextIndicatorResult;
	public float result1 = 1000;


	// Update is called once per frame
	void Update () {
		if (currentAmount < 100) {
			currentAmount += speed * Time.deltaTime;
			TextIndicator.GetComponent<Text>().text = ((int)currentAmount).ToString()+"%";
		} else {
			TextIndicator.GetComponent<Text>().text = "Done!";
		}

		//Progress bar
		//if (scoreCount < 1000) {
		//	TextIndicator.GetComponent<Text>().text = ((int)scoreCount).ToString();
		//	TextIndicatorResult.GetComponent<Text>().text = ((int)result1).ToString();
		//} else {
		//	TextIndicator.GetComponent<Text>().text = "Done!";
		//}

		//LoadingBar.GetComponent<Image> ().fillAmount = scoreCount / result1;





		LoadingBar.GetComponent<Image> ().fillAmount = currentAmount / 100;
	}
}
