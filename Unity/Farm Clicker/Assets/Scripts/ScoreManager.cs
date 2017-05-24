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
	public decimal pointsPerTouch;
	public decimal pointsPerTouch2;
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

	void Start () {
		m_source = gameObject.GetComponent<AudioSource>();
		playerName = PlayerPrefs.GetString ("Name");
		//verify if score already exist in PlayerPrefs
		if (PlayerPrefs.HasKey ("Score")) {
			scoreCount = decimal.Parse (PlayerPrefs.GetString("Score"));

			//verify if seeds already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("seedsCost") && PlayerPrefs.HasKey ("seedsLevel") && PlayerPrefs.HasKey ("seedsCPS")) {
				seedsCost = decimal.Parse (PlayerPrefs.GetString("seedsCost"));
				seedsLevel = decimal.Parse (PlayerPrefs.GetString("seedsLevel"));
				seedsCPS = decimal.Parse (PlayerPrefs.GetString("seedsCPS"));
				pointsPerSecond += seedsCPS;
				imgSeeds.SetActive(true);
				//verify to unlock flowers
				if (seedsLevel >= 25) {
					btnFlowers.GetComponent<Button>().interactable = true;
				} else {
					btnFlowers.GetComponent<Button>().interactable = false;
				}
				//seeds txt update
				seedsCPSTxt.text = "C.P.S : " + seedsCPS;
				seedsLevelTxt.text = "Level : " + seedsLevel;
				seedsCostTxt.text = seedsCost + "$";
			} else {
				seedsCost = 3;
				seedsLevel = 0;
				seedsCPS = 1;
				//lock flowers
				btnFlowers.GetComponent<Button>().interactable = false;
				//seeds txt update
				seedsCPSTxt.text = "C.P.S : " + seedsCPS;
				seedsLevelTxt.text = "Level : " + seedsLevel;
				seedsCostTxt.text = seedsCost + "$";
			}
		} else {	//Show welcome message at first launch
			WelcomeActive = true;
			panelWelcome.SetActive (true);
		}
		pointsPerTouch = 0;
		pointsPerTouch2 = 1;


	}

	void Update () {
		//detect a mouse clik when no other panel is active
		if (Input.GetMouseButtonDown(0) && TaskActive == false && ShopActive == false && WelcomeActive == false && instructionsActive == false) {
			m_source.clip = clickMoney;
			m_source.Play();
			scoreCount++;
			if (scoreCount >= 25 && scoreCount <= 49) {
				scoreCount += pointsPerTouch;
			}
			if (scoreCount >= 50 && scoreCount <= 99) {
				scoreCount += pointsPerTouch2;
			}

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
	public void BuySeeds () {
		if (scoreCount >= seedsCost) {
			scoreCount -= seedsCost;
			seedsLevel += 1;
			seedsCPS += 2;
			pointsPerSecond += seedsCPS;
			seedsCost += 25;
			imgSeeds.SetActive(true);
		}
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
		string seedsCPSSave = seedsCPS.ToString ();
		string seedsLevelSave = seedsLevel.ToString ();
		string seedsCostSave = seedsCost.ToString ();
		PlayerPrefs.SetString ("seedsCPS", seedsCPSSave);
		PlayerPrefs.SetString ("seedsLevel", seedsLevelSave);
		PlayerPrefs.SetString ("seedsCost", seedsCostSave);
	}

	public void BuyFlowers () {
		if (seedsLevel >= 25) {
			if (scoreCount >= flowersCost) {
				scoreCount -= flowersCost;
				flowersLevel += 1;
				flowersCPS += 3;
				pointsPerSecond += flowersCPS;
				flowersCost += 75;
				imgFlowers.SetActive(true);
			}
		}
		//enable the flowers
		if (flowersLevel >= 25) {
			btnTomato.GetComponent<Button>().interactable = true;
		}
		//flowers txt update
		flowersCPSTxt.text = "C.P.S : " + flowersCPS;
		flowersLevelTxt.text = "Level : " + flowersLevel;
		flowersCostTxt.text = flowersCost + "$";
		string flowersCPSSave = flowersCPS.ToString ();
		string flowersLevelSave = flowersLevel.ToString ();
		string flowersCostSave = flowersCost.ToString ();
		PlayerPrefs.SetString ("flowersCPS", flowersCPSSave);
		PlayerPrefs.SetString ("flowersLevel", flowersLevelSave);
		PlayerPrefs.SetString ("flowersCost", flowersCostSave);
	}

	public void BuyTomato () {
		if (scoreCount >= tomatoCost) {
			scoreCount -= tomatoCost;
			tomatoLevel += 1;
			tomatoCPS += 6;
			pointsPerSecond += tomatoCPS;
			tomatoCost += 100;
			imgTomato.SetActive(true);
		}
		//tomato txt update
		tomatoCPSTxt.text = "C.P.S : " + tomatoCPS;
		tomatoLevelTxt.text = "Level : " + tomatoLevel;
		tomatoCostTxt.text = tomatoCost + "$";
		string tomatoCPSSave = tomatoCPS.ToString ();
		string tomatoLevelSave = tomatoLevel.ToString ();
		string tomatoCostSave = tomatoCost.ToString ();
		PlayerPrefs.SetString ("tomatoCPS", tomatoCPSSave);
		PlayerPrefs.SetString ("tomatoLevel", tomatoLevelSave);
		PlayerPrefs.SetString ("tomatoCost", tomatoCostSave);
	}

	public void BuyTree () {
		if (scoreCount >= TreeCost) {
			scoreCount -= TreeCost;
			TreeLevel += 1;
			TreeCPS += 9;
			pointsPerSecond += TreeCPS;
			TreeCost += 250;
			imgTree.SetActive(true);
		}
		//Tree txt update
		TreeCPSTxt.text = "C.P.S : " + TreeCPS;
		TreeLevelTxt.text = "Level : " + TreeLevel;
		TreeCostTxt.text = TreeCost + "$";
		string TreeCPSSave = TreeCPS.ToString ();
		string TreeLevelSave = TreeLevel.ToString ();
		string TreeCostSave = TreeCost.ToString ();
		PlayerPrefs.SetString ("TreeCPS", TreeCPSSave);
		PlayerPrefs.SetString ("TreeLevel", TreeLevelSave);
		PlayerPrefs.SetString ("TreeCost", TreeCostSave);
	}

	public void BuyGreenApple () {
		if (scoreCount >= GreenAppleCost) {
			scoreCount -= GreenAppleCost;
			GreenAppleLevel += 1;
			GreenAppleCPS += 3;
			pointsPerSecond += GreenAppleCPS;
			//GreenAppleCost = Mathf.RoundToInt (GreenAppleCost * Mathf.Pow (1.05f, GreenAppleLevel));
			imgGreenApple.SetActive(true);
		}
		//GreenApple txt update
		GreenAppleCPSTxt.text = "C.P.S : " + GreenAppleCPS;
		GreenAppleLevelTxt.text = "Level : " + GreenAppleLevel;
		GreenAppleCostTxt.text = GreenAppleCost + "$";
		string GreenAppleCPSSave = GreenAppleCPS.ToString ();
		string GreenAppleLevelSave = GreenAppleLevel.ToString ();
		string GreenAppleCostSave = GreenAppleCost.ToString ();
		PlayerPrefs.SetString ("GreenAppleCPS", GreenAppleCPSSave);
		PlayerPrefs.SetString ("GreenAppleLevel", GreenAppleLevelSave);
		PlayerPrefs.SetString ("GreenAppleCost", GreenAppleCostSave);
	}

	public void BuyCarrot () {
		if (scoreCount >= CarrotCost) {
			scoreCount -= CarrotCost;
			CarrotLevel += 1;
			CarrotCPS += 3;
			pointsPerSecond += CarrotCPS;
			//CarrotCost = Mathf.RoundToInt (CarrotCost * Mathf.Pow (1.05f, CarrotLevel));
			imgCarrot.SetActive(true);
		}
		//Carrot txt update
		CarrotCPSTxt.text = "C.P.S : " + CarrotCPS;
		CarrotLevelTxt.text = "Level : " + CarrotLevel;
		CarrotCostTxt.text = CarrotCost + "$";
		string CarrotCPSSave = CarrotCPS.ToString ();
		string CarrotLevelSave = CarrotLevel.ToString ();
		string CarrotCostSave = CarrotCost.ToString ();
		PlayerPrefs.SetString ("CarrotCPS", CarrotCPSSave);
		PlayerPrefs.SetString ("CarrotLevel", CarrotLevelSave);
		PlayerPrefs.SetString ("CarrotCost", CarrotCostSave);
	}

	public void BuyGreenPear () {
		if (scoreCount >= GreenPearCost) {
			scoreCount -= GreenPearCost;
			GreenPearLevel += 1;
			GreenPearCPS += 3;
			pointsPerSecond += GreenPearCPS;
			//GreenPearCost = Mathf.RoundToInt (GreenPearCost * Mathf.Pow (1.05f, GreenPearLevel));
			imgGreenPear.SetActive(true);
		}
		//GreenPear txt update
		GreenPearCPSTxt.text = "C.P.S : " + GreenPearCPS;
		GreenPearLevelTxt.text = "Level : " + GreenPearLevel;
		GreenPearCostTxt.text = GreenPearCost + "$";
		string GreenPearCPSSave = GreenPearCPS.ToString ();
		string GreenPearLevelSave = GreenPearLevel.ToString ();
		string GreenPearCostSave = GreenPearCost.ToString ();
		PlayerPrefs.SetString ("GreenPearCPS", GreenPearCPSSave);
		PlayerPrefs.SetString ("GreenPearLevel", GreenPearLevelSave);
		PlayerPrefs.SetString ("GreenPearCost", GreenPearCostSave);
	}

	public void BuyCorn () {
		if (scoreCount >= CornCost) {
			scoreCount -= CornCost;
			CornLevel += 1;
			CornCPS += 3;
			pointsPerSecond += CornCPS;
			//CornCost = Mathf.RoundToInt (CornCost * Mathf.Pow (1.05f, CornLevel));
			imgCorn.SetActive(true);
		}
		//Corn txt update
		CornCPSTxt.text = "C.P.S : " + CornCPS;
		CornLevelTxt.text = "Level : " + CornLevel;
		CornCostTxt.text = CornCost + "$";
		string CornCPSSave = CornCPS.ToString ();
		string CornLevelSave = CornLevel.ToString ();
		string CornCostSave = CornCost.ToString ();
		PlayerPrefs.SetString ("CornCPS", CornCPSSave);
		PlayerPrefs.SetString ("CornLevel", CornLevelSave);
		PlayerPrefs.SetString ("CornCost", CornCostSave);
	}

	public void BuyRedApple () {
		if (scoreCount >= RedAppleCost) {
			scoreCount -= RedAppleCost;
			RedAppleLevel += 1;
			RedAppleCPS += 3;
			pointsPerSecond += RedAppleCPS;
			//RedAppleCost = Mathf.RoundToInt (RedAppleCost * Mathf.Pow (1.05f, RedAppleLevel));
			imgRedApple.SetActive(true);
		}
		//RedApple txt update
		RedAppleCPSTxt.text = "C.P.S : " + RedAppleCPS;
		RedAppleLevelTxt.text = "Level : " + RedAppleLevel;
		RedAppleCostTxt.text = RedAppleCost + "$";
		string RedAppleCPSSave = RedAppleCPS.ToString ();
		string RedAppleLevelSave = RedAppleLevel.ToString ();
		string RedAppleCostSave = RedAppleCost.ToString ();
		PlayerPrefs.SetString ("RedAppleCPS", RedAppleCPSSave);
		PlayerPrefs.SetString ("RedAppleLevel", RedAppleLevelSave);
		PlayerPrefs.SetString ("RedAppleCost", RedAppleCostSave);
	}

	public void BuyWatermelon () {
		if (scoreCount >= WatermelonCost) {
			scoreCount -= WatermelonCost;
			WatermelonLevel += 1;
			WatermelonCPS += 3;
			pointsPerSecond += WatermelonCPS;
			//WatermelonCost = Mathf.RoundToInt (WatermelonCost * Mathf.Pow (1.05f, WatermelonLevel));
			imgWatermelon.SetActive(true);
		}
		//Watermelon txt update
		WatermelonCPSTxt.text = "C.P.S : " + WatermelonCPS;
		WatermelonLevelTxt.text = "Level : " + WatermelonLevel;
		WatermelonCostTxt.text = WatermelonCost + "$";
		string WatermelonCPSSave = WatermelonCPS.ToString ();
		string WatermelonLevelSave = WatermelonLevel.ToString ();
		string WatermelonCostSave = WatermelonCost.ToString ();
		PlayerPrefs.SetString ("WatermelonCPS", WatermelonCPSSave);
		PlayerPrefs.SetString ("WatermelonLevel", WatermelonLevelSave);
		PlayerPrefs.SetString ("WatermelonCost", WatermelonCostSave);
	}

	public void BuyRedPear () {
		if (scoreCount >= RedPearCost) {
			scoreCount -= RedPearCost;
			RedPearLevel += 1;
			RedPearCPS += 3;
			pointsPerSecond += RedPearCPS;
			//RedPearCost = Mathf.RoundToInt (RedPearCost * Mathf.Pow (1.05f, RedPearLevel));
			imgRedPear.SetActive(true);
		}
		//RedPear txt update
		RedPearCPSTxt.text = "C.P.S : " + RedPearCPS;
		RedPearLevelTxt.text = "Level : " + RedPearLevel;
		RedPearCostTxt.text = RedPearCost + "$";
		string RedPearCPSSave = RedPearCPS.ToString ();
		string RedPearLevelSave = RedPearLevel.ToString ();
		string RedPearCostSave = RedPearCost.ToString ();
		PlayerPrefs.SetString ("RedPearCPS", RedPearCPSSave);
		PlayerPrefs.SetString ("RedPearLevel", RedPearLevelSave);
		PlayerPrefs.SetString ("RedPearCost", RedPearCostSave);
	}

	public void BuyPumpkin () {
		if (scoreCount >= PumpkinCost) {
			scoreCount -= PumpkinCost;
			PumpkinLevel += 1;
			PumpkinCPS += 3;
			pointsPerSecond += PumpkinCPS;
			//PumpkinCost = Mathf.RoundToInt (PumpkinCost * Mathf.Pow (1.05f, PumpkinLevel));
			imgPumpkin.SetActive(true);
		}
		//Pumpkin txt update
		PumpkinCPSTxt.text = "C.P.S : " + PumpkinCPS;
		PumpkinLevelTxt.text = "Level : " + PumpkinLevel;
		PumpkinCostTxt.text = PumpkinCost + "$";
		string PumpkinCPSSave = PumpkinCPS.ToString ();
		string PumpkinLevelSave = PumpkinLevel.ToString ();
		string PumpkinCostSave = PumpkinCost.ToString ();
		PlayerPrefs.SetString ("PumpkinCPS", PumpkinCPSSave);
		PlayerPrefs.SetString ("PumpkinLevel", PumpkinLevelSave);
		PlayerPrefs.SetString ("PumpkinCost", PumpkinCostSave);
	}

	public void BuyWrench () {
		if (scoreCount >= WrenchCost) {
			scoreCount -= WrenchCost;
			WrenchLevel += 1;
			WrenchCPS += 3;
			pointsPerSecond += WrenchCPS;
			//WrenchCost = Mathf.RoundToInt (WrenchCost * Mathf.Pow (1.05f, WrenchLevel));
			imgWrench.SetActive(true);
		}
		//Wrench txt update
		WrenchCPSTxt.text = "C.P.S : " + WrenchCPS;
		WrenchLevelTxt.text = "Level : " + WrenchLevel;
		WrenchCostTxt.text = WrenchCost + "$";
		string WrenchCPSSave = WrenchCPS.ToString ();
		string WrenchLevelSave = WrenchLevel.ToString ();
		string WrenchCostSave = WrenchCost.ToString ();
		PlayerPrefs.SetString ("WrenchCPS", WrenchCPSSave);
		PlayerPrefs.SetString ("WrenchLevel", WrenchLevelSave);
		PlayerPrefs.SetString ("WrenchCost", WrenchCostSave);
	}

	public void BuyScrewdriver () {
		if (scoreCount >= ScrewdriverCost) {
			scoreCount -= ScrewdriverCost;
			ScrewdriverLevel += 1;
			ScrewdriverCPS += 3;
			pointsPerSecond += ScrewdriverCPS;
			//ScrewdriverCost = Mathf.RoundToInt (ScrewdriverCost * Mathf.Pow (1.05f, ScrewdriverLevel));
			imgScrewdriver.SetActive(true);
		}
		//Screwdriver txt update
		ScrewdriverCPSTxt.text = "C.P.S : " + ScrewdriverCPS;
		ScrewdriverLevelTxt.text = "Level : " + ScrewdriverLevel;
		ScrewdriverCostTxt.text = ScrewdriverCost + "$";
		string ScrewdriverCPSSave = ScrewdriverCPS.ToString ();
		string ScrewdriverLevelSave = ScrewdriverLevel.ToString ();
		string ScrewdriverCostSave = ScrewdriverCost.ToString ();
		PlayerPrefs.SetString ("ScrewdriverCPS", ScrewdriverCPSSave);
		PlayerPrefs.SetString ("ScrewdriverLevel", ScrewdriverLevelSave);
		PlayerPrefs.SetString ("ScrewdriverCost", ScrewdriverCostSave);
	}

	public void BuyHammer () {
		if (scoreCount >= HammerCost) {
			scoreCount -= HammerCost;
			HammerLevel += 1;
			HammerCPS += 3;
			pointsPerSecond += HammerCPS;
			//HammerCost = Mathf.RoundToInt (HammerCost * Mathf.Pow (1.05f, HammerLevel));
			imgHammer.SetActive(true);
		}
		//Hammer txt update
		HammerCPSTxt.text = "C.P.S : " + HammerCPS;
		HammerLevelTxt.text = "Level : " + HammerLevel;
		HammerCostTxt.text = HammerCost + "$";
		string HammerCPSSave = HammerCPS.ToString ();
		string HammerLevelSave = HammerLevel.ToString ();
		string HammerCostSave = HammerCost.ToString ();
		PlayerPrefs.SetString ("HammerCPS", HammerCPSSave);
		PlayerPrefs.SetString ("HammerLevel", HammerLevelSave);
		PlayerPrefs.SetString ("HammerCost", HammerCostSave);
	}

	public void BuyHandsaw () {
		if (scoreCount >= HandsawCost) {
			scoreCount -= HandsawCost;
			HandsawLevel += 1;
			HandsawCPS += 3;
			pointsPerSecond += HandsawCPS;
			//HandsawCost = Mathf.RoundToInt (HandsawCost * Mathf.Pow (1.05f, HandsawLevel));
			imgHandsaw.SetActive(true);
		}
		//Handsaw txt update
		HandsawCPSTxt.text = "C.P.S : " + HandsawCPS;
		HandsawLevelTxt.text = "Level : " + HandsawLevel;
		HandsawCostTxt.text = HandsawCost + "$";
		string HandsawCPSSave = HandsawCPS.ToString ();
		string HandsawLevelSave = HandsawLevel.ToString ();
		string HandsawCostSave = HandsawCost.ToString ();
		PlayerPrefs.SetString ("HandsawCPS", HandsawCPSSave);
		PlayerPrefs.SetString ("HandsawLevel", HandsawLevelSave);
		PlayerPrefs.SetString ("HandsawCost", HandsawCostSave);
	}

	public void BuyFence () {
		if (scoreCount >= FenceCost) {
			scoreCount -= FenceCost;
			FenceLevel += 1;
			FenceCPS += 3;
			pointsPerSecond += FenceCPS;
			//FenceCost = Mathf.RoundToInt (FenceCost * Mathf.Pow (1.05f, FenceLevel));
			imgFence.SetActive(true);
		}
		//Fence txt update
		FenceCPSTxt.text = "C.P.S : " + FenceCPS;
		FenceLevelTxt.text = "Level : " + FenceLevel;
		FenceCostTxt.text = FenceCost + "$";
		string FenceCPSSave = FenceCPS.ToString ();
		string FenceLevelSave = FenceLevel.ToString ();
		string FenceCostSave = FenceCost.ToString ();
		PlayerPrefs.SetString ("FenceCPS", FenceCPSSave);
		PlayerPrefs.SetString ("FenceLevel", FenceLevelSave);
		PlayerPrefs.SetString ("FenceCost", FenceCostSave);
	}

	public void BuyDog () {
		if (scoreCount >= DogCost) {
			scoreCount -= DogCost;
			DogLevel += 1;
			DogCPS += 3;
			pointsPerSecond += DogCPS;
			//DogCost = Mathf.RoundToInt (DogCost * Mathf.Pow (1.05f, DogLevel));
			imgDog.SetActive(true);
		}
		//Dog txt update
		DogCPSTxt.text = "C.P.S : " + DogCPS;
		DogLevelTxt.text = "Level : " + DogLevel;
		DogCostTxt.text = DogCost + "$";
		string DogCPSSave = DogCPS.ToString ();
		string DogLevelSave = DogLevel.ToString ();
		string DogCostSave = DogCost.ToString ();
		PlayerPrefs.SetString ("DogCPS", DogCPSSave);
		PlayerPrefs.SetString ("DogLevel", DogLevelSave);
		PlayerPrefs.SetString ("DogCost", DogCostSave);
	}

	public void BuyCat () {
		if (scoreCount >= CatCost) {
			scoreCount -= CatCost;
			CatLevel += 1;
			CatCPS += 3;
			pointsPerSecond += CatCPS;
			//CatCost = Mathf.RoundToInt (CatCost * Mathf.Pow (1.05f, CatLevel));
			imgCat.SetActive(true);
		}
		//Cat txt update
		CatCPSTxt.text = "C.P.S : " + CatCPS;
		CatLevelTxt.text = "Level : " + CatLevel;
		CatCostTxt.text = CatCost + "$";
		string CatCPSSave = CatCPS.ToString ();
		string CatLevelSave = CatLevel.ToString ();
		string CatCostSave = CatCost.ToString ();
		PlayerPrefs.SetString ("CatCPS", CatCPSSave);
		PlayerPrefs.SetString ("CatLevel", CatLevelSave);
		PlayerPrefs.SetString ("CatCost", CatCostSave);
	}

	public void BuyChicken () {
		if (scoreCount >= ChickenCost) {
			scoreCount -= ChickenCost;
			ChickenLevel += 1;
			ChickenCPS += 3;
			pointsPerSecond += ChickenCPS;
			//ChickenCost = Mathf.RoundToInt (ChickenCost * Mathf.Pow (1.05f, ChickenLevel));
			imgChicken.SetActive(true);
		}
		//Chicken txt update
		ChickenCPSTxt.text = "C.P.S : " + ChickenCPS;
		ChickenLevelTxt.text = "Level : " + ChickenLevel;
		ChickenCostTxt.text = ChickenCost + "$";
		string ChickenCPSSave = ChickenCPS.ToString ();
		string ChickenLevelSave = ChickenLevel.ToString ();
		string ChickenCostSave = ChickenCost.ToString ();
		PlayerPrefs.SetString ("ChickenCPS", ChickenCPSSave);
		PlayerPrefs.SetString ("ChickenLevel", ChickenLevelSave);
		PlayerPrefs.SetString ("ChickenCost", ChickenCostSave);
	}

	public void BuyPig () {
		if (scoreCount >= PigCost) {
			scoreCount -= PigCost;
			PigLevel += 1;
			PigCPS += 3;
			pointsPerSecond += PigCPS;
			//PigCost = Mathf.RoundToInt (PigCost * Mathf.Pow (1.05f, PigLevel));
			imgPig.SetActive(true);
		}
		//Pig txt update
		PigCPSTxt.text = "C.P.S : " + PigCPS;
		PigLevelTxt.text = "Level : " + PigLevel;
		PigCostTxt.text = PigCost + "$";
		string PigCPSSave = PigCPS.ToString ();
		string PigLevelSave = PigLevel.ToString ();
		string PigCostSave = PigCost.ToString ();
		PlayerPrefs.SetString ("PigCPS", PigCPSSave);
		PlayerPrefs.SetString ("PigLevel", PigLevelSave);
		PlayerPrefs.SetString ("PigCost", PigCostSave);
	}

	public void BuySheep () {
		if (scoreCount >= SheepCost) {
			scoreCount -= SheepCost;
			SheepLevel += 1;
			SheepCPS += 3;
			pointsPerSecond += SheepCPS;
			//SheepCost = Mathf.RoundToInt (SheepCost * Mathf.Pow (1.05f, SheepLevel));
			imgSheep.SetActive(true);
		}
		//Sheep txt update
		SheepCPSTxt.text = "C.P.S : " + SheepCPS;
		SheepLevelTxt.text = "Level : " + SheepLevel;
		SheepCostTxt.text = SheepCost + "$";
		string SheepCPSSave = SheepCPS.ToString ();
		string SheepLevelSave = SheepLevel.ToString ();
		string SheepCostSave = SheepCost.ToString ();
		PlayerPrefs.SetString ("SheepCPS", SheepCPSSave);
		PlayerPrefs.SetString ("SheepLevel", SheepLevelSave);
		PlayerPrefs.SetString ("SheepCost", SheepCostSave);
	}

	public void BuyCow () {
		if (scoreCount >= CowCost) {
			scoreCount -= CowCost;
			CowLevel += 1;
			CowCPS += 3;
			pointsPerSecond += CowCPS;
			//CowCost = Mathf.RoundToInt (CowCost * Mathf.Pow (1.05f, CowLevel));
			imgCow.SetActive(true);
		}
		//Cow txt update
		CowCPSTxt.text = "C.P.S : " + CowCPS;
		CowLevelTxt.text = "Level : " + CowLevel;
		CowCostTxt.text = CowCost + "$";
		string CowCPSSave = CowCPS.ToString ();
		string CowLevelSave = CowLevel.ToString ();
		string CowCostSave = CowCost.ToString ();
		PlayerPrefs.SetString ("CowCPS", CowCPSSave);
		PlayerPrefs.SetString ("CowLevel", CowLevelSave);
		PlayerPrefs.SetString ("CowCost", CowCostSave);
	}

	public void BuyHorse () {
		if (scoreCount >= HorseCost) {
			scoreCount -= HorseCost;
			HorseLevel += 1;
			HorseCPS += 3;
			pointsPerSecond += HorseCPS;
			//HorseCost = Mathf.RoundToInt (HorseCost * Mathf.Pow (1.05f, HorseLevel));
			imgHorse.SetActive(true);
		}
		//Horse txt update
		HorseCPSTxt.text = "C.P.S : " + HorseCPS;
		HorseLevelTxt.text = "Level : " + HorseLevel;
		HorseCostTxt.text = HorseCost + "$";
		string HorseCPSSave = HorseCPS.ToString ();
		string HorseLevelSave = HorseLevel.ToString ();
		string HorseCostSave = HorseCost.ToString ();
		PlayerPrefs.SetString ("HorseCPS", HorseCPSSave);
		PlayerPrefs.SetString ("HorseLevel", HorseLevelSave);
		PlayerPrefs.SetString ("HorseCost", HorseCostSave);
	}

	public void BuyGoldPear () {
		if (scoreCount >= GoldPearCost) {
			scoreCount -= GoldPearCost;
			GoldPearLevel += 1;
			GoldPearCPS += 3;
			pointsPerSecond += GoldPearCPS;
			//GoldPearCost = Mathf.RoundToInt (GoldPearCost * Mathf.Pow (1.05f, GoldPearLevel));
			imgGoldPear.SetActive(true);
		}
		//GoldPear txt update
		GoldPearCPSTxt.text = "C.P.S : " + GoldPearCPS;
		GoldPearLevelTxt.text = "Level : " + GoldPearLevel;
		GoldPearCostTxt.text = GoldPearCost + "$";
		string GoldPearCPSSave = GoldPearCPS.ToString ();
		string GoldPearLevelSave = GoldPearLevel.ToString ();
		string GoldPearCostSave = GoldPearCost.ToString ();
		PlayerPrefs.SetString ("GoldPearCPS", GoldPearCPSSave);
		PlayerPrefs.SetString ("GoldPearLevel", GoldPearLevelSave);
		PlayerPrefs.SetString ("GoldPearCost", GoldPearCostSave);
	}

	public void BuyBarn () {
		if (scoreCount >= BarnCost) {
			scoreCount -= BarnCost;
			BarnLevel += 1;
			BarnCPS += 3;
			pointsPerSecond += BarnCPS;
			//BarnCost = Mathf.RoundToInt (BarnCost * Mathf.Pow (1.05f, BarnLevel));
			imgBarn.SetActive(true);
		}
		//Barn txt update
		BarnCPSTxt.text = "C.P.S : " + BarnCPS;
		BarnLevelTxt.text = "Level : " + BarnLevel;
		BarnCostTxt.text = BarnCost + "$";
		string BarnCPSSave = BarnCPS.ToString ();
		string BarnLevelSave = BarnLevel.ToString ();
		string BarnCostSave = BarnCost.ToString ();
		PlayerPrefs.SetString ("BarnCPS", BarnCPSSave);
		PlayerPrefs.SetString ("BarnLevel", BarnLevelSave);
		PlayerPrefs.SetString ("BarnCost", BarnCostSave);
	}

	public void BuyTractor () {
		if (scoreCount >= TractorCost) {
			scoreCount -= TractorCost;
			TractorLevel += 1;
			TractorCPS += 3;
			pointsPerSecond += TractorCPS;
			//TractorCost = Mathf.RoundToInt (TractorCost * Mathf.Pow (1.05f, TractorLevel));
			imgTractor.SetActive(true);
		}
		//Tractor txt update
		TractorCPSTxt.text = "C.P.S : " + TractorCPS;
		TractorLevelTxt.text = "Level : " + TractorLevel;
		TractorCostTxt.text = TractorCost + "$";
		string TractorCPSSave = TractorCPS.ToString ();
		string TractorLevelSave = TractorLevel.ToString ();
		string TractorCostSave = TractorCost.ToString ();
		PlayerPrefs.SetString ("TractorCPS", TractorCPSSave);
		PlayerPrefs.SetString ("TractorLevel", TractorLevelSave);
		PlayerPrefs.SetString ("TractorCost", TractorCostSave);
	}

	public void BuyMill () {
		if (scoreCount >= MillCost) {
			scoreCount -= MillCost;
			MillLevel += 1;
			MillCPS += 3;
			pointsPerSecond += MillCPS;
			//MillCost = Mathf.RoundToInt (MillCost * Mathf.Pow (1.05f, MillLevel));
			imgMill.SetActive(true);
		}
		//Mill txt update
		MillCPSTxt.text = "C.P.S : " + MillCPS;
		MillLevelTxt.text = "Level : " + MillLevel;
		MillCostTxt.text = MillCost + "$";
		string MillCPSSave = MillCPS.ToString ();
		string MillLevelSave = MillLevel.ToString ();
		string MillCostSave = MillCost.ToString ();
		PlayerPrefs.SetString ("MillCPS", MillCPSSave);
		PlayerPrefs.SetString ("MillLevel", MillLevelSave);
		PlayerPrefs.SetString ("MillCost", MillCostSave);
	}

	public void BuyGoldApple () {
		if (scoreCount >= GoldAppleCost) {
			scoreCount -= GoldAppleCost;
			GoldAppleLevel += 1;
			GoldAppleCPS += 3;
			pointsPerSecond += GoldAppleCPS;
			//GoldAppleCost = Mathf.RoundToInt (GoldAppleCost * Mathf.Pow (1.05f, GoldAppleLevel));
			imgGoldApple.SetActive(true);
		}
		//GoldApple txt update
		GoldAppleCPSTxt.text = "C.P.S : " + GoldAppleCPS;
		GoldAppleLevelTxt.text = "Level : " + GoldAppleLevel;
		GoldAppleCostTxt.text = GoldAppleCost + "$";
		string GoldAppleCPSSave = GoldAppleCPS.ToString ();
		string GoldAppleLevelSave = GoldAppleLevel.ToString ();
		string GoldAppleCostSave = GoldAppleCost.ToString ();
		PlayerPrefs.SetString ("GoldAppleCPS", GoldAppleCPSSave);
		PlayerPrefs.SetString ("GoldAppleLevel", GoldAppleLevelSave);
		PlayerPrefs.SetString ("GoldAppleCost", GoldAppleCostSave);
	}
}
