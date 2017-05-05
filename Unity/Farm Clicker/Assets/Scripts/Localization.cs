using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Localization : MonoBehaviour {

	Dictionary<string, string> EN;
	Dictionary<string, string> FR;
	Dictionary<string, string> CurrentLang;

	//langue en cours
	string CurrentLangStr = "EN";

	//list of textfields to update
	List<GameObject> m_textFieldList;

	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad (gameObject);

		m_textFieldList = new List<GameObject> ();

		EN = new Dictionary<string, string>();
		EN["BTN_PLAY"] = "Play";
		EN["INPUT_NAME"] = "Enter your name...";
		EN["BTN_LANGUAGE"] = "Language";
		EN["BTN_FRANCAIS"] = "French";
		EN["BTN_ENGLISH"] = "English";
		EN["BTN_RESTART"] = "Restart";
		EN["BTN_EXIT"] = "Exit";

		FR = new  Dictionary<string, string>();
		FR["BTN_PLAY"] = "Jouer";
		FR["INPUT_NAME"] = "Entrer votre nom...";
		FR["BTN_LANGUAGE"] = "Langue";
		FR["BTN_FRANCAIS"] = "Français";
		FR["BTN_ENGLISH"] = "Anglais";
		FR["BTN_RESTART"] = "Recommencer";
		FR["BTN_EXIT"] = "Quitter";

		//what should be the defualt loaded language?
		if (CurrentLangStr == "EN") {
			CurrentLang = EN;
		} else {
			CurrentLang = FR;
		}
	}

	//Get a localized string value
	public string GetString(string a_key)
	{
		return CurrentLang[a_key];
	}

	//registers a textfield to be notified when lang is changed
	public void RegisterTextField(GameObject a_textField){
		m_textFieldList.Add (a_textField);
	}

	//switch the current localized lang
	public void SwitchCurrentLang()
	{
		if (CurrentLangStr == "EN") {
			CurrentLangStr = "FR";
			CurrentLang = FR;
		} else {
			CurrentLangStr = "EN";
			CurrentLang = EN;
		}

		//we loop through each registered textfield and we trigger a text update for it
		for (int i = 0; i < m_textFieldList.Count; i++) {
			m_textFieldList [i].GetComponent<GetLocalizedText> ().UpdateText ();
		}
	}
}
