using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public GameObject imgMoney;
	private GameObject spawnImgMoney;
	public Text scoreText;
	public decimal scoreCount;
	public decimal pointsPerSecond;
	private float RandomGoToPositionX;
	private float RandomGoToPositionY;
	public float lastUpdate;

	//Seeds
	public GameObject imgSeeds;
	public decimal seedsLevel;
	public decimal seedsCPS;
	public decimal seedsCost;
	public Text seedsLevelTxt;
	public Text seedsCPSTxt;
	public Text seedsCostTxt;

	//Flowers
	public GameObject btnFlowers;
	public GameObject imgFlowers;
	public decimal flowersLevel;
	public decimal flowersCPS;
	public decimal flowersCost;
	public Text flowersLevelTxt;
	public Text flowersCPSTxt;
	public Text flowersCostTxt;

	//Tomato
	public GameObject btnTomato;
	public GameObject imgTomato;
	public decimal tomatoLevel;
	public decimal tomatoCPS;
	public decimal tomatoCost;
	public Text tomatoLevelTxt;
	public Text tomatoCPSTxt;
	public Text tomatoCostTxt;

	//Tree
	public GameObject btnTree;
	public GameObject imgTree;
	public decimal TreeLevel;
	public decimal TreeCPS;
	public decimal TreeCost;
	public Text TreeLevelTxt;
	public Text TreeCPSTxt;
	public Text TreeCostTxt;

	//GreenApple
	public GameObject btnGreenApple;
	public GameObject imgGreenApple;
	public decimal GreenAppleLevel;
	public decimal GreenAppleCPS;
	public decimal GreenAppleCost;
	public Text GreenAppleLevelTxt;
	public Text GreenAppleCPSTxt;
	public Text GreenAppleCostTxt;

	//Carrot
	public GameObject btnCarrot;
	public GameObject imgCarrot;
	public decimal CarrotLevel;
	public decimal CarrotCPS;
	public decimal CarrotCost;
	public Text CarrotLevelTxt;
	public Text CarrotCPSTxt;
	public Text CarrotCostTxt;

	//GreenPear
	public GameObject btnGreenPear;
	public GameObject imgGreenPear;
	public decimal GreenPearLevel;
	public decimal GreenPearCPS;
	public decimal GreenPearCost;
	public Text GreenPearLevelTxt;
	public Text GreenPearCPSTxt;
	public Text GreenPearCostTxt;

	//Corn
	public GameObject btnCorn;
	public GameObject imgCorn;
	public decimal CornLevel;
	public decimal CornCPS;
	public decimal CornCost;
	public Text CornLevelTxt;
	public Text CornCPSTxt;
	public Text CornCostTxt;

	//RedApple
	public GameObject btnRedApple;
	public GameObject imgRedApple;
	public decimal RedAppleLevel;
	public decimal RedAppleCPS;
	public decimal RedAppleCost;
	public Text RedAppleLevelTxt;
	public Text RedAppleCPSTxt;
	public Text RedAppleCostTxt;

	//Watermelon
	public GameObject btnWatermelon;
	public GameObject imgWatermelon;
	public decimal WatermelonLevel;
	public decimal WatermelonCPS;
	public decimal WatermelonCost;
	public Text WatermelonLevelTxt;
	public Text WatermelonCPSTxt;
	public Text WatermelonCostTxt;

	//RedPear
	public GameObject btnRedPear;
	public GameObject imgRedPear;
	public decimal RedPearLevel;
	public decimal RedPearCPS;
	public decimal RedPearCost;
	public Text RedPearLevelTxt;
	public Text RedPearCPSTxt;
	public Text RedPearCostTxt;

	//Pumpkin
	public GameObject btnPumpkin;
	public GameObject imgPumpkin;
	public decimal PumpkinLevel;
	public decimal PumpkinCPS;
	public decimal PumpkinCost;
	public Text PumpkinLevelTxt;
	public Text PumpkinCPSTxt;
	public Text PumpkinCostTxt;

	//Wrench
	public GameObject btnWrench;
	public GameObject imgWrench;
	public decimal WrenchLevel;
	public decimal WrenchCPS;
	public decimal WrenchCost;
	public Text WrenchLevelTxt;
	public Text WrenchCPSTxt;
	public Text WrenchCostTxt;

	//Screwdriver
	public GameObject btnScrewdriver;
	public GameObject imgScrewdriver;
	public decimal ScrewdriverLevel;
	public decimal ScrewdriverCPS;
	public decimal ScrewdriverCost;
	public Text ScrewdriverLevelTxt;
	public Text ScrewdriverCPSTxt;
	public Text ScrewdriverCostTxt;

	//Hammer
	public GameObject btnHammer;
	public GameObject imgHammer;
	public decimal HammerLevel;
	public decimal HammerCPS;
	public decimal HammerCost;
	public Text HammerLevelTxt;
	public Text HammerCPSTxt;
	public Text HammerCostTxt;

	//Handsaw
	public GameObject btnHandsaw;
	public GameObject imgHandsaw;
	public decimal HandsawLevel;
	public decimal HandsawCPS;
	public decimal HandsawCost;
	public Text HandsawLevelTxt;
	public Text HandsawCPSTxt;
	public Text HandsawCostTxt;

	//Fence
	public GameObject btnFence;
	public GameObject imgFence;
	public decimal FenceLevel;
	public decimal FenceCPS;
	public decimal FenceCost;
	public Text FenceLevelTxt;
	public Text FenceCPSTxt;
	public Text FenceCostTxt;

	//Dog
	public GameObject btnDog;
	public GameObject imgDog;
	public decimal DogLevel;
	public decimal DogCPS;
	public decimal DogCost;
	public Text DogLevelTxt;
	public Text DogCPSTxt;
	public Text DogCostTxt;

	//Cat
	public GameObject btnCat;
	public GameObject imgCat;
	public decimal CatLevel;
	public decimal CatCPS;
	public decimal CatCost;
	public Text CatLevelTxt;
	public Text CatCPSTxt;
	public Text CatCostTxt;

	//Chicken
	public GameObject btnChicken;
	public GameObject imgChicken;
	public decimal ChickenLevel;
	public decimal ChickenCPS;
	public decimal ChickenCost;
	public Text ChickenLevelTxt;
	public Text ChickenCPSTxt;
	public Text ChickenCostTxt;

	//Pig
	public GameObject btnPig;
	public GameObject imgPig;
	public decimal PigLevel;
	public decimal PigCPS;
	public decimal PigCost;
	public Text PigLevelTxt;
	public Text PigCPSTxt;
	public Text PigCostTxt;

	//Sheep
	public GameObject btnSheep;
	public GameObject imgSheep;
	public decimal SheepLevel;
	public decimal SheepCPS;
	public decimal SheepCost;
	public Text SheepLevelTxt;
	public Text SheepCPSTxt;
	public Text SheepCostTxt;

	//Cow
	public GameObject btnCow;
	public GameObject imgCow;
	public decimal CowLevel;
	public decimal CowCPS;
	public decimal CowCost;
	public Text CowLevelTxt;
	public Text CowCPSTxt;
	public Text CowCostTxt;

	//Horse
	public GameObject btnHorse;
	public GameObject imgHorse;
	public decimal HorseLevel;
	public decimal HorseCPS;
	public decimal HorseCost;
	public Text HorseLevelTxt;
	public Text HorseCPSTxt;
	public Text HorseCostTxt;

	//GoldPear
	public GameObject btnGoldPear;
	public GameObject imgGoldPear;
	public decimal GoldPearLevel;
	public decimal GoldPearCPS;
	public decimal GoldPearCost;
	public Text GoldPearLevelTxt;
	public Text GoldPearCPSTxt;
	public Text GoldPearCostTxt;

	//Barn
	public GameObject btnBarn;
	public GameObject imgBarn;
	public decimal BarnLevel;
	public decimal BarnCPS;
	public decimal BarnCost;
	public Text BarnLevelTxt;
	public Text BarnCPSTxt;
	public Text BarnCostTxt;

	//Tractor
	public GameObject btnTractor;
	public GameObject imgTractor;
	public decimal TractorLevel;
	public decimal TractorCPS;
	public decimal TractorCost;
	public Text TractorLevelTxt;
	public Text TractorCPSTxt;
	public Text TractorCostTxt;

	//Mill
	public GameObject btnMill;
	public GameObject imgMill;
	public decimal MillLevel;
	public decimal MillCPS;
	public decimal MillCost;
	public Text MillLevelTxt;
	public Text MillCPSTxt;
	public Text MillCostTxt;

	//GoldApple
	public GameObject btnGoldApple;
	public GameObject imgGoldApple;
	public decimal GoldAppleLevel;
	public decimal GoldAppleCPS;
	public decimal GoldAppleCost;
	public Text GoldAppleLevelTxt;
	public Text GoldAppleCPSTxt;
	public Text GoldAppleCostTxt;

	//notepad screens
	public GameObject imgNotepad;
	public GameObject scrollViewTask;
	public GameObject scrollViewShop;
	public bool TaskActive = false;
	public bool ShopActive = false;

	//intro
	public GameObject panelWelcome;
	public GameObject panelInstructions;
	public GameObject btnInstructions;
	public string playerName;
	public bool WelcomeActive;
	public bool instructionsActive;

	public AudioClip clickMoney;
	AudioSource m_source;

	void Awake () {
		//verify if score data already exist in PlayerPrefs
		if (PlayerPrefs.HasKey ("Score")) {
			scoreCount = decimal.Parse (PlayerPrefs.GetString("Score"));




			//verify if seeds data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("seedsCost") && PlayerPrefs.HasKey ("seedsLevel") && PlayerPrefs.HasKey ("seedsCPS")) {
				Debug.Log ("if seeds");
				//retreive seeds data and convert it to decimal
				seedsCost = decimal.Parse (PlayerPrefs.GetString("seedsCost"));
				seedsLevel = decimal.Parse (PlayerPrefs.GetString("seedsLevel"));
				seedsCPS = decimal.Parse (PlayerPrefs.GetString("seedsCPS"));
				//add pre-existing seeds data to pointsPerSecond
				pointsPerSecond += seedsCPS;
				imgSeeds.SetActive(true);
				//verify to unlock next object
				if (seedsLevel >= 25) {
					btnFlowers.GetComponent<Button>().interactable = true;
				} else {
					btnFlowers.GetComponent<Button>().interactable = false;
				}
				//seeds txt update
				seedsCPSTxt.text = "C.P.S : " + seedsCPS;
				seedsLevelTxt.text = "Level : " + seedsLevel;
				seedsCostTxt.text = seedsCost + "$";
			}




			//verify if flowers data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("flowersCost") && PlayerPrefs.HasKey ("flowersLevel") && PlayerPrefs.HasKey ("flowersCPS")) {
				//retreive flowers data and convert it to decimal
				flowersCost = decimal.Parse (PlayerPrefs.GetString("flowersCost"));
				flowersLevel = decimal.Parse (PlayerPrefs.GetString("flowersLevel"));
				flowersCPS = decimal.Parse (PlayerPrefs.GetString("flowersCPS"));
				//add pre-existing flowers data to pointsPerSecond
				pointsPerSecond += flowersCPS;
				imgFlowers.SetActive(true);
				//verify to unlock next object
				if (flowersLevel >= 25) {
					btnTomato.GetComponent<Button>().interactable = true;
				} else {
					btnTomato.GetComponent<Button>().interactable = false;
				}
				//flowers txt update
				flowersCPSTxt.text = "C.P.S : " + flowersCPS;
				flowersLevelTxt.text = "Level : " + flowersLevel;
				flowersCostTxt.text = flowersCost + "$";
			}




			//verify if tomato data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("tomatoCost") && PlayerPrefs.HasKey ("tomatoLevel") && PlayerPrefs.HasKey ("tomatoCPS")) {
				//retreive tomato data and convert it to decimal
				tomatoCost = decimal.Parse (PlayerPrefs.GetString("tomatoCost"));
				tomatoLevel = decimal.Parse (PlayerPrefs.GetString("tomatoLevel"));
				tomatoCPS = decimal.Parse (PlayerPrefs.GetString("tomatoCPS"));
				//add pre-existing tomato data to pointsPerSecond
				pointsPerSecond += tomatoCPS;
				imgTomato.SetActive(true);
				//verify to unlock next object
				if (tomatoLevel >= 25) {
					btnTomato.GetComponent<Button>().interactable = true;
				} else {
					btnTomato.GetComponent<Button>().interactable = false;
				}
				//tomato txt update
				tomatoCPSTxt.text = "C.P.S : " + tomatoCPS;
				tomatoLevelTxt.text = "Level : " + tomatoLevel;
				tomatoCostTxt.text = tomatoCost + "$";
			} else {
				//set tomato default values
				tomatoCost = 3;
				tomatoLevel = 0;
				tomatoCPS = 1;
				//lock tomato
				btnTomato.GetComponent<Button>().interactable = false;
				//tomato txt update
				tomatoCPSTxt.text = "C.P.S : " + tomatoCPS;
				tomatoLevelTxt.text = "Level : " + tomatoLevel;
				tomatoCostTxt.text = tomatoCost + "$";
			}

		} else {	//Show welcome message at first launch
			WelcomeActive = true;
			panelWelcome.SetActive (true);




			//set seeds default values
			seedsCost = 3;
			seedsLevel = 0;
			seedsCPS = 1;
			//seeds txt update
			seedsCPSTxt.text = "C.P.S : " + seedsCPS;
			seedsLevelTxt.text = "Level : " + seedsLevel;
			seedsCostTxt.text = seedsCost + "$";
			Debug.Log ("Seeds values set");




			//set flowers default values
			flowersCost = 9;
			flowersLevel = 0;
			flowersCPS = 3;
			//lock flowers
			btnFlowers.GetComponent<Button>().interactable = false;
			//flowers txt update
			flowersCPSTxt.text = "C.P.S : " + flowersCPS;
			flowersLevelTxt.text = "Level : " + flowersLevel;
			flowersCostTxt.text = flowersCost + "$";
			Debug.Log ("Flowers values set");
		}
	}

	void Start () {
		m_source = gameObject.GetComponent<AudioSource>();
	}

	void Update () {
		//detect a mouse clik when no other panel is active
		if (Input.GetMouseButtonDown(0) && TaskActive == false && ShopActive == false && WelcomeActive == false && instructionsActive == false) {
			m_source.clip = clickMoney;
			m_source.Play();
			scoreCount++;

			//money animation generation
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

		if(Time.time - lastUpdate >= 1f){
			scoreCount += pointsPerSecond;
			lastUpdate = Time.time;
		}

		scoreText.text = " " + scoreCount + " ";
		string mymoney = scoreCount.ToString ();
		PlayerPrefs.SetString ("Score", mymoney);
		PlayerPrefs.Save();
	}

	//btnShowInstructions showing
	public void OnBtnShowInstructionsClick () {
		instructionsActive = true;
		WelcomeActive = false;
		panelWelcome.SetActive(false);
		imgNotepad.SetActive(true);
		panelInstructions.SetActive(true);
		btnInstructions.SetActive(true);
		ShopActive = false;
		TaskActive = false;
		scrollViewShop.SetActive(false);
		scrollViewTask.SetActive(false);
	}

	//btnSkipInstructions showing
	public void OnBtnSkipInstructionsClick () {
		instructionsActive = false;
		WelcomeActive = false;
		panelWelcome.SetActive(false);
		imgNotepad.SetActive(false);
		panelInstructions.SetActive(false);
		btnInstructions.SetActive(false);
	}

	//notepad task click
	public void OnBtnTaskClick () {
		if (TaskActive == false) {
			TaskActive = true;
			imgNotepad.SetActive(true);
			scrollViewTask.SetActive(true);
			ShopActive = false;
			scrollViewShop.SetActive(false);
		} else {
			TaskActive = false;
			imgNotepad.SetActive(false);
			scrollViewTask.SetActive(false);
		}
	}

	//notepad shop click
	public void OnBtnShopClick () {
		if (ShopActive == false) {
			ShopActive = true;
			imgNotepad.SetActive(true);
			scrollViewShop.SetActive(true);
			TaskActive = false;
			scrollViewTask.SetActive(false);
		} else {
			ShopActive = false;
			imgNotepad.SetActive(false);
			scrollViewShop.SetActive(false);
		}
	}
		
	//-------------------------------------------------  Shop  -------------------------------------------------
	//--------------------------  seeds  --------------------------
	public void BuySeeds () {
		//check for the money available
		if (scoreCount >= seedsCost) {
			scoreCount -= seedsCost;
			seedsLevel += 1;
			seedsCPS += 2;
			pointsPerSecond += seedsCPS;
			seedsCost += 25;
			imgSeeds.SetActive(true);
		}
		//cheat for developper...........................................don't forget to delete at the end.
		if (seedsLevel > 3) {
			pointsPerSecond += 10000000000000000000;
		}
		//enable the flowers
		if (seedsLevel >= 25) {
			btnFlowers.GetComponent<Button>().interactable = true;
		}
		//seeds txt update
		seedsCPSTxt.text = "C.P.S : " + seedsCPS;
		seedsLevelTxt.text = "Level : " + seedsLevel;
		seedsCostTxt.text = seedsCost + "$";
		//convert seeds data to string to save in PlayerPrefs
		string seedsCPSSave = seedsCPS.ToString ();
		string seedsLevelSave = seedsLevel.ToString ();
		string seedsCostSave = seedsCost.ToString ();
		//save seeds data to PlayerPrefs
		PlayerPrefs.SetString ("seedsCPS", seedsCPSSave);
		PlayerPrefs.SetString ("seedsLevel", seedsLevelSave);
		PlayerPrefs.SetString ("seedsCost", seedsCostSave);
	}

	//--------------------------  flowers  --------------------------
	public void BuyFlowers () {
		if (seedsLevel >= 25) {
			//check for the money available
			if (scoreCount >= flowersCost) {
				scoreCount -= flowersCost;
				flowersLevel += 1;
				flowersCPS += 3;
				pointsPerSecond += flowersCPS;
				flowersCost += 75;
				imgFlowers.SetActive(true);
			}
		}
		//enable the tomato
		if (flowersLevel >= 25) {
			btnTomato.GetComponent<Button>().interactable = true;
		}
		//flowers txt update
		flowersCPSTxt.text = "C.P.S : " + flowersCPS;
		flowersLevelTxt.text = "Level : " + flowersLevel;
		flowersCostTxt.text = flowersCost + "$";
		//convert flowers data to string to save in PlayerPrefs
		string flowersCPSSave = flowersCPS.ToString ();
		string flowersLevelSave = flowersLevel.ToString ();
		string flowersCostSave = flowersCost.ToString ();
		//save flowers data to PlayerPrefs
		PlayerPrefs.SetString ("flowersCPS", flowersCPSSave);
		PlayerPrefs.SetString ("flowersLevel", flowersLevelSave);
		PlayerPrefs.SetString ("flowersCost", flowersCostSave);
	}

	//--------------------------  tomato  --------------------------
	public void BuyTomato () {
		if (flowersLevel >= 25) {
			//check for the money available
			if (scoreCount >= tomatoCost) {
				scoreCount -= tomatoCost;
				tomatoLevel += 1;
				tomatoCPS += 3;
				pointsPerSecond += tomatoCPS;
				tomatoCost += 75;
				imgTomato.SetActive(true);
			}
		}
		//enable the Tree
		if (tomatoLevel >= 25) {
			btnTree.GetComponent<Button>().interactable = true;
		}
		//tomato txt update
		tomatoCPSTxt.text = "C.P.S : " + tomatoCPS;
		tomatoLevelTxt.text = "Level : " + tomatoLevel;
		tomatoCostTxt.text = tomatoCost + "$";
		//convert tomato data to string to save in PlayerPrefs
		string tomatoCPSSave = tomatoCPS.ToString ();
		string tomatoLevelSave = tomatoLevel.ToString ();
		string tomatoCostSave = tomatoCost.ToString ();
		//save tomato data to PlayerPrefs
		PlayerPrefs.SetString ("tomatoCPS", tomatoCPSSave);
		PlayerPrefs.SetString ("tomatoLevel", tomatoLevelSave);
		PlayerPrefs.SetString ("tomatoCost", tomatoCostSave);
	}

	public void BuyTree () {
		
	}

	public void BuyGreenApple () {
		
	}

	public void BuyCarrot () {
		
	}

	public void BuyGreenPear () {
		
	}

	public void BuyCorn () {
		
	}

	public void BuyRedApple () {
		
	}

	public void BuyWatermelon () {
		
	}

	public void BuyRedPear () {
		
	}

	public void BuyPumpkin () {
		
	}

	public void BuyWrench () {
		
	}

	public void BuyScrewdriver () {
		
	}

	public void BuyHammer () {
		
	}

	public void BuyHandsaw () {
		
	}

	public void BuyFence () {
		
	}

	public void BuyDog () {
		
	}

	public void BuyCat () {
		
	}

	public void BuyChicken () {
		
	}

	public void BuyPig () {
		
	}

	public void BuySheep () {
		
	}

	public void BuyCow () {
		
	}

	public void BuyHorse () {
		
	}

	public void BuyGoldPear () {
		
	}

	public void BuyBarn () {
		
	}

	public void BuyTractor () {
		
	}

	public void BuyMill () {
		
	}

	public void BuyGoldApple () {
		
	}
}
