using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightSwitch : MonoBehaviour {

	public GameObject imgDay;
	public GameObject imgNight;

	// Use this for initialization
	void Start () {
		Invoke ("SwitchToDay", 0f);
	}

	void SwitchToNight () {
		LeanTween.rotate (imgNight.GetComponent<RectTransform>(), 360f, 10f);
		LeanTween.alpha(imgDay, 1f, 5f).setDelay(5f);
		imgDay.GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,0f);
		Invoke ("SwitchToDay", 10f);
	}

	void SwitchToDay () {
		LeanTween.rotate (imgDay.GetComponent<RectTransform>(), 360f, 10f);
		LeanTween.alpha(imgNight, 1f, 5f).setDelay(5f);
		imgNight.GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,1f);
		Invoke ("SwitchToNight", 10f);
	}

	void ResetDay () {
		LeanTween.alpha(imgDay, 1f, 0f);
		imgDay.GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,1f);
		Invoke ("SwitchToDay", 0f);
	}

	void ResetNight () {
		LeanTween.alpha(imgDay, 1f, 0f);
		imgDay.GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,1f);
		Invoke ("SwitchToNight", 0f);
	}
}
