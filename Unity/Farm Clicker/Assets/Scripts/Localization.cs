using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Localization : MonoBehaviour {

	public bool enableFR;
	public bool enableEN;
	public GameObject btnFrancais;
	public GameObject btnEnglish;
	Dictionary<string, string> EN;
	Dictionary<string, string> FR;
	Dictionary<string, string> CurrentLang;

	// Use this for initialization
	void Awake () {
		EN = new Dictionary<string, string>();
		EN["NAME"] = "Enter your name...";
		EN["PLAY"] = "Play";
		EN["LANGUAGE"] = "Language";
		EN["FRENCH"] = "French";
		EN["ENGLISH"] = "English";
		EN["RESTART"] = "Restart";
		EN["EXIT"] = "Exit";
		EN[""] = "";
		EN[""] = "";
		EN[""] = "";
		EN[""] = "";
		EN[""] = "";
		EN[""] = "";
		EN[""] = "";
		EN[""] = "";
		EN[""] = "";
		EN[""] = "";
		EN[""] = "";
		EN[""] = "";
		EN[""] = "";
		EN[""] = "";
		EN[""] = "";
		EN[""] = "";
		EN[""] = "";


		FR = new  Dictionary<string, string>();
		FR["NAME"] = "Entrez votre nom...";
		FR["PLAY"] = "Jouer";
		FR["LANGUAGE"] = "Langue";
		FR["FRENCH"] = "Français";
		FR["ENGLISH"] = "Anglais";
		FR["RESTART"] = "Recommencer";
		FR["EXIT"] = "Quitter";
		FR[""] = "";
		FR[""] = "";
		FR[""] = "";
		FR[""] = "";
		FR[""] = "";
		FR[""] = "";
		FR[""] = "";
		FR[""] = "";
		FR[""] = "";
		FR[""] = "";
		FR[""] = "";
		FR[""] = "";
		FR[""] = "";

		enableEN = true;
		enableFR = false;

		if (enableFR == true) {
			CurrentLang = FR;
			Debug.Log("French");
		} else if (enableEN == true) {
			CurrentLang = EN;
			Debug.Log("English");
		}
	}


	public void onFrenchClick()
	{
		enableEN = false;
		enableFR = true;
	}

	public void onEnglishClick()
	{
		enableEN = true;
		enableFR = false;
	}


	public string GetString(string a_key)
	{
		return CurrentLang[a_key];
	}

	public void SetCurrentLang(string a_lang)
	{
		if (a_lang == "EN") {
			CurrentLang = EN;
		} else{
			CurrentLang = FR;
		}
	}
}
