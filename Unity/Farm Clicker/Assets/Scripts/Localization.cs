using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Localization : MonoBehaviour {

	public GameObject btnEnglish;
	public GameObject btnFrench;
	public AudioClip btnSound;

	public string playerName;

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

		playerName = PlayerPrefs.GetString("Name");

		EN = new Dictionary<string, string>();

		//menu screen
		EN ["BTN_PLAY"] = "Play";
		EN ["BTN_CONTINUE"] = "Continue";
		EN["INPUT_NAME"] = "Enter your name...";
		EN["BTN_LANGUAGE"] = "Language";
		EN["BTN_FRANCAIS"] = "French";
		EN["BTN_ENGLISH"] = "English";
		EN["BTN_RESTART"] = "Restart";
		EN["BTN_CONFIRM"] = "Confirm";
		EN["BTN_CANCEL"] = "Cancel";
		EN["BTN_EXIT"] = "Exit";

		//player customization screen
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

		//welcome screen
		EN["WELCOME_MSG"] = "Hi, do you want the instructions?";
		EN["BTN_SHOW"] = "Show";
		EN["BTN_SKIP"] = "Skip";

		//instructions screen
		EN["INSTRUCTIONS_TITLE"] = "Instructions";
		EN["INSTRUCTIONS_NUMBER1"] = "1. Click anywhere on the screen to get more corn dollars.";
		EN["INSTRUCTIONS_NUMBER2"] = "2. You can buy object and other stuffs on the shop. It will make you earn a certain amount of corn dollars every second. The more object you have the more you earn. Levels give you more corn dollars per second.";
		EN["INSTRUCTIONS_NUMBER3"] = "3. Finishing task will give you a special gift. Some might be better than other!";
		EN["INSTRUCTIONS_END"] = "Don't forget to have fun    :D";
		EN["INSTRUCTIONS_CLOSE"] = "(Close this by pressing the instructions button)";
		EN["BTN_INSTRUCTIONS"] = "Instructions";

		//game screen
		EN["BTN_SHOP"] = "Shop";
		EN["BTN_TASK"] = "Task";
		EN["CORN_DOLLARS"] = "Corn dollars";




		FR = new  Dictionary<string, string>();

		//menu screen
		FR["BTN_PLAY"] = "Jouer";
		FR ["BTN_CONTINUE"] = "Continuer";
		FR["INPUT_NAME"] = "Entrer votre nom...";
		FR["BTN_LANGUAGE"] = "Langue";
		FR["BTN_FRANCAIS"] = "Français";
		FR["BTN_ENGLISH"] = "Anglais";
		FR["BTN_RESTART"] = "Recommencer";
		FR["BTN_CONFIRM"] = "Confirmer";
		FR["BTN_CANCEL"] = "Annuler";
		FR["BTN_EXIT"] = "Quitter";

		//player customization screen
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

		//welcome screen
		FR["WELCOME_MSG"] = "Bonjour, voulez-vous voir les instructions?";
		FR["BTN_SHOW"] = "Afficher";
		FR["BTN_SKIP"] = "Passer";

		//instructions screen
		FR["INSTRUCTIONS_TITLE"] = "Instructions";
		FR["INSTRUCTIONS_NUMBER1"] = "1. Appuyer n'importe où sur l'écran pour gagner des billets de maïs.";
		FR["INSTRUCTIONS_NUMBER2"] = "2. Vous pouvez acheter des oubjets et autres choses dans le magasin. Cela vous feras gagner un certain nombre de billet de maïs par seconde. Plus vous avez d'objet plus vous gagner. Les niveaux vous donne aussi plus de billet de maïs par seconde.";
		FR["INSTRUCTIONS_NUMBER3"] = "3. Finir des tâches vous donneras des cadeaux spéciaux. Certains seront meilleur que d'autre.";
		FR["INSTRUCTIONS_END"] = "N'oubliez pas de vous amusez    :D";
		FR["INSTRUCTIONS_CLOSE"] = "(Fermer cette fenêtre avec le boutton Instructions)";
		FR["BTN_INSTRUCTIONS"] = "Instructions";

		//game screen
		FR["BTN_SHOP"] = "Magasin";
		FR["BTN_TASK"] = "Tâches";
		FR["CORN_DOLLARS"] = "Billet de Maïs";



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
