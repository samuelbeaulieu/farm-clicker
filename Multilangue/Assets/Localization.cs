using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Localization : MonoBehaviour {

	Dictionary<string, string> EN;
	Dictionary<string, string> FR;
	Dictionary<string, string> CurrentLang;

	// Use this for initialization
	void Awake () {
		EN = new Dictionary<string, string>();
		EN["TITLE"] = "This is a title";


		FR = new  Dictionary<string, string>();
		FR["TITLE"] = "Ceci est un titre";

		//ici on dit quelle est la langue en cours
		CurrentLang = EN;
	}
	
	public string GetString(string a_key)
	{
		return CurrentLang[a_key];
	}

	public void SetCurrentLang(string a_lang)
	{
		if (a_lang == "EN") {
			CurrentLang = EN;
		} else
			CurrentLang = FR;
	}
}
