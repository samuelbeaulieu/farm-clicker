﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnimMenu : MonoBehaviour {

	public GameObject Logo;
	public GameObject inputName;
	public GameObject btnPlay;
	public GameObject btnMenu;
	public GameObject imgIcon;
	public GameObject imgIconX;
	public GameObject imgMenu;
	public GameObject btnLanguage;
	public GameObject btnFrancais;
	public GameObject btnEnglish;
	public GameObject btnRestart;
	public GameObject btnExit;
	public GameObject txtMenu;
	public GameObject txtCopy;
	public GameObject panelPlayerCustomization;
	public GameObject panelMenu;
	public AudioClip btnSound;
	public bool menuActive = false;
	public bool menuLanguageActive = false;

	AudioSource m_source;

	void Start () {
		m_source = gameObject.GetComponent<AudioSource>();
        panelPlayerCustomization.SetActive(false);
	}

	public void OnBtnMenuClick()
	{
		if (menuActive == false) {
			m_source.clip = btnSound;
			m_source.Play();
			imgIcon.SetActive(false);
			imgIconX.SetActive(true);
			LeanTween.moveLocalX(btnMenu, -474.7f, 0.5f);
			LeanTween.moveLocalX(imgMenu, -741.51f, 0.5f);
			LeanTween.moveLocalX(txtMenu, -741.51f, 0.5f);
			LeanTween.moveLocalX(btnLanguage, -734.51f, 0.5f);
			LeanTween.moveLocalX(btnFrancais, -734.51f, 0.5f);
			LeanTween.moveLocalX(btnEnglish, -734.51f, 0.5f);
			LeanTween.moveLocalX(btnRestart, -734.51f, 0.5f);
			LeanTween.moveLocalX(btnExit, -734.51f, 0.5f);
			LeanTween.moveLocalX(txtCopy, -741.51f, 0.5f);
			menuActive = true;
		} else if (menuActive == true) {
			m_source.clip = btnSound;
			m_source.Play();
			imgIcon.SetActive(true);
			imgIconX.SetActive(false);
			if (menuLanguageActive == true) {
				LeanTween.moveLocalY(btnFrancais, 275f, 0.25f);
				LeanTween.moveLocalY(btnEnglish, 275f, 0.25f);
				LeanTween.moveLocalY(btnRestart, 150f, 0.25f);
				LeanTween.moveLocalY(btnExit, 25f, 0.25f);
			}
			LeanTween.moveLocalX(btnMenu, -912.3f, 0.5f);
			LeanTween.moveLocalX(imgMenu, -1178.5f, 0.5f);
			LeanTween.moveLocalX(txtMenu, -1178.5f, 0.5f);
			LeanTween.moveLocalX(btnLanguage, -1172f, 0.5f);
			LeanTween.moveLocalX(btnFrancais, -1172f, 0.5f);
			LeanTween.moveLocalX(btnEnglish, -1172f, 0.5f);
			LeanTween.moveLocalX(btnRestart, -1172f, 0.5f);
			LeanTween.moveLocalX(btnExit, -1172f, 0.5f);
			LeanTween.moveLocalX(txtCopy, -1178.5f, 0.5f);
			menuActive = false;
		}
	}

	public void OnBtnLanguageClick()
	{
		if (menuLanguageActive == false) {
			m_source.clip = btnSound;
			m_source.Play();
			LeanTween.moveLocalY(btnFrancais, 125f, 0.25f);
			LeanTween.moveLocalY(btnEnglish, 175f, 0.25f);
			LeanTween.moveLocalY(btnRestart, 25f, 0.25f);
			LeanTween.moveLocalY(btnExit, -100f, 0.25f);
			menuLanguageActive = true;
		} else if (menuLanguageActive == true) {
			m_source.clip = btnSound;
			m_source.Play();
			LeanTween.moveLocalY(btnFrancais, 275f, 0.25f);
			LeanTween.moveLocalY(btnEnglish, 275f, 0.25f);
			LeanTween.moveLocalY(btnRestart, 150f, 0.25f);
			LeanTween.moveLocalY(btnExit, 25f, 0.25f);
			menuLanguageActive = false;
		}
	}
	
    public void OnInputFieldClick()
	{
		m_source.clip = btnSound;
		m_source.Play();
	}
    
	public void OnBtnPlayClick()
	{
		m_source.clip = btnSound;
		m_source.Play();

		panelPlayerCustomization.SetActive(true);
		panelMenu.SetActive(false);
	}
}
