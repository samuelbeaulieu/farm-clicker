using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Localization : MonoBehaviour {

	public GameObject btnEnglish;
	public GameObject btnFrench;
	public AudioClip btnSound;

	Dictionary<string, string> EN;
	Dictionary<string, string> FR;
	Dictionary<string, string> CurrentLang;
	AudioSource m_source;
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

		EN["PLAYER_CUSTOM_TITLE"] = "Player Customization";
        EN["PREV_HAT"] = "Previous hat";
        EN["NEXT_HAT"] = "Next hat";
        EN["PREV_HAIR_COLOR"] = "Previous hair color";
        EN["NEXT_HAIR_COLOR"] = "Next hair color";
        EN["PREV_EYEBROWS"] = "Previous eyebrows";
        EN["NEXT_EYEBROWS"] = "Next eyebrows";
        EN["PREV_EYES_COLOR"] = "Previous eyes color";
        EN["NEXT_EYES_COLOR"] = "Next eyes color";
        EN["PREV_MUSTACHE"] = "Previous mustache";
        EN["NEXT_MUSTACHE"] = "Next mustache";
        EN["PREV_SKIN_COLOR"] = "Previous skin color";
        EN["NEXT_SKIN_COLOR"] = "Next skin color";
        EN["PREV_SHIRT"] = "Previous shirt";
        EN["NEXT_SHIRT"] = "Next shirt";
        EN["PREV_OVERALLS"] = "Previous overalls";
        EN["NEXT_OVERALLS"] = "Next overalls";
        EN["PREV_SLEEVES"] = "Previous sleeves";
        EN["NEXT_SLEEVES"] = "Next sleeves";
        EN["PREV_BOOTS"] = "Previous boots";
        EN["NEXT_BOOTS"] = "Next boots";
        EN["BOY"] = "Boy";
        EN["GIRL"] = "Girl";
        EN["RANDOM"] = "Random";
        EN["BTN_CONTINUE"] = "Continue";

		FR = new  Dictionary<string, string>();
		FR["BTN_PLAY"] = "Jouer";
		FR["INPUT_NAME"] = "Entrer votre nom...";
		FR["BTN_LANGUAGE"] = "Langue";
		FR["BTN_FRANCAIS"] = "Français";
		FR["BTN_ENGLISH"] = "Anglais";
		FR["BTN_RESTART"] = "Recommencer";
		FR["BTN_EXIT"] = "Quitter";

        FR["PLAYER_CUSTOM_TITLE"] = "Modification du joueur";
        FR["PREV_HAT"] = "Chapeau précédent";
        FR["NEXT_HAT"] = "Chapeau suivant";
        FR["PREV_HAIR_COLOR"] = "Cheveux précédent";
        FR["NEXT_HAIR_COLOR"] = "Cheveux suivant";
        FR["PREV_EYEBROWS"] = "Sourcis précédent";
        FR["NEXT_EYEBROWS"] = "Sourcis suivant";
        FR["PREV_EYES_COLOR"] = "Yeux précédent";
        FR["NEXT_EYES_COLOR"] = "Yeux suivant";
        FR["PREV_MUSTACHE"] = "Moustache précédente";
        FR["NEXT_MUSTACHE"] = "Moustache suivante";
        FR["PREV_SKIN_COLOR"] = "Peau précédente";
        FR["NEXT_SKIN_COLOR"] = "Peau suivante";
        FR["PREV_SHIRT"] = "Chandail précédent";
        FR["NEXT_SHIRT"] = "Chandail suivant";
        FR["PREV_OVERALLS"] = "Salopette précédente";
        FR["NEXT_OVERALLS"] = "Salopette suivante";
        FR["PREV_SLEEVES"] = "Manches précédentes";
        FR["NEXT_SLEEVES"] = "Manches suivantes";
        FR["PREV_BOOTS"] = "Bottes précédentes";
        FR["NEXT_BOOTS"] = "Bottes suivantes";
        FR["BOY"] = "Garçons";
        FR["GIRL"] = "Fille";
        FR["RANDOM"] = "Aléatoire";
        FR["BTN_CONTINUE"] = "Continuer";

		//what should be the defualt loaded language?
		if (CurrentLangStr == "EN") {
			CurrentLang = EN;
			btnEnglish.GetComponent<Button>().interactable = false;
			btnFrench.GetComponent<Button>().interactable = true;
		} else {
			CurrentLang = FR;
			btnEnglish.GetComponent<Button>().interactable = true;
			btnFrench.GetComponent<Button>().interactable = false;
		}
	}

	void Start () {
		m_source = gameObject.GetComponent<AudioSource>();
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
			m_source.clip = btnSound;
			m_source.Play();
			CurrentLangStr = "FR";
			CurrentLang = FR;
			btnEnglish.GetComponent<Button>().interactable = true;
			btnFrench.GetComponent<Button>().interactable = false;
		} else {
			m_source.clip = btnSound;
			m_source.Play();
			CurrentLangStr = "EN";
			CurrentLang = EN;
			btnEnglish.GetComponent<Button>().interactable = false;
			btnFrench.GetComponent<Button>().interactable = true;
		}

		//we loop through each registered textfield and we trigger a text update for it
		for (int i = 0; i < m_textFieldList.Count; i++) {
			m_textFieldList [i].GetComponent<GetLocalizedText> ().UpdateText ();
		}
	}
}
