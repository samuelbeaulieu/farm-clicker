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
	public decimal seedsPointsPerSecond;
	public Text seedsLevelTxt;
	public Text seedsCPSTxt;
	public Text seedsCostTxt;

	//Flowers
	public GameObject btnFlowers;
	public GameObject imgFlowers;
	public decimal flowersLevel;
	public decimal flowersCPS;
	public decimal flowersCost;
	public decimal FlowersPointsPerSecond;
	public Text flowersLevelTxt;
	public Text flowersCPSTxt;
	public Text flowersCostTxt;

	//Tomato
	public GameObject btnTomato;
	public GameObject imgTomato;
	public decimal tomatoLevel;
	public decimal tomatoCPS;
	public decimal tomatoCost;
	public decimal TomatoPointsPerSecond;
	public Text tomatoLevelTxt;
	public Text tomatoCPSTxt;
	public Text tomatoCostTxt;

	//Tree
	public GameObject btnTree;
	public GameObject imgTree;
	public decimal TreeLevel;
	public decimal TreeCPS;
	public decimal TreeCost;
	public decimal TreePointsPerSecond;
	public Text TreeLevelTxt;
	public Text TreeCPSTxt;
	public Text TreeCostTxt;

	//GreenApple
	public GameObject btnGreenApple;
	public GameObject imgGreenApple;
	public decimal GreenAppleLevel;
	public decimal GreenAppleCPS;
	public decimal GreenAppleCost;
	public decimal GreenApplePointsPerSecond;
	public Text GreenAppleLevelTxt;
	public Text GreenAppleCPSTxt;
	public Text GreenAppleCostTxt;

	//Carrot
	public GameObject btnCarrot;
	public GameObject imgCarrot;
	public decimal CarrotLevel;
	public decimal CarrotCPS;
	public decimal CarrotCost;
	public decimal CarrotPointsPerSecond;
	public Text CarrotLevelTxt;
	public Text CarrotCPSTxt;
	public Text CarrotCostTxt;

	//GreenPear
	public GameObject btnGreenPear;
	public GameObject imgGreenPear;
	public decimal GreenPearLevel;
	public decimal GreenPearCPS;
	public decimal GreenPearCost;
	public decimal GreenPearPointsPerSecond;
	public Text GreenPearLevelTxt;
	public Text GreenPearCPSTxt;
	public Text GreenPearCostTxt;

	//Corn
	public GameObject btnCorn;
	public GameObject imgCorn;
	public decimal CornLevel;
	public decimal CornCPS;
	public decimal CornCost;
	public decimal CornPointsPerSecond;
	public Text CornLevelTxt;
	public Text CornCPSTxt;
	public Text CornCostTxt;

	//RedApple
	public GameObject btnRedApple;
	public GameObject imgRedApple;
	public decimal RedAppleLevel;
	public decimal RedAppleCPS;
	public decimal RedAppleCost;
	public decimal RedApplePointsPerSecond;
	public Text RedAppleLevelTxt;
	public Text RedAppleCPSTxt;
	public Text RedAppleCostTxt;

	//Watermelon
	public GameObject btnWatermelon;
	public GameObject imgWatermelon;
	public decimal WatermelonLevel;
	public decimal WatermelonCPS;
	public decimal WatermelonCost;
	public decimal WatermelonPointsPerSecond;
	public Text WatermelonLevelTxt;
	public Text WatermelonCPSTxt;
	public Text WatermelonCostTxt;

	//RedPear
	public GameObject btnRedPear;
	public GameObject imgRedPear;
	public decimal RedPearLevel;
	public decimal RedPearCPS;
	public decimal RedPearCost;
	public decimal RedPearPointsPerSecond;
	public Text RedPearLevelTxt;
	public Text RedPearCPSTxt;
	public Text RedPearCostTxt;

	//Pumpkin
	public GameObject btnPumpkin;
	public GameObject imgPumpkin;
	public decimal PumpkinLevel;
	public decimal PumpkinCPS;
	public decimal PumpkinCost;
	public decimal PumpkinPointsPerSecond;
	public Text PumpkinLevelTxt;
	public Text PumpkinCPSTxt;
	public Text PumpkinCostTxt;

	//Wrench
	public GameObject btnWrench;
	public GameObject imgWrench;
	public decimal WrenchLevel;
	public decimal WrenchCPS;
	public decimal WrenchCost;
	public decimal WrenchPointsPerSecond;
	public Text WrenchLevelTxt;
	public Text WrenchCPSTxt;
	public Text WrenchCostTxt;

	//Screwdriver
	public GameObject btnScrewdriver;
	public GameObject imgScrewdriver;
	public decimal ScrewdriverLevel;
	public decimal ScrewdriverCPS;
	public decimal ScrewdriverCost;
	public decimal ScrewdriverPointsPerSecond;
	public Text ScrewdriverLevelTxt;
	public Text ScrewdriverCPSTxt;
	public Text ScrewdriverCostTxt;

	//Hammer
	public GameObject btnHammer;
	public GameObject imgHammer;
	public decimal HammerLevel;
	public decimal HammerCPS;
	public decimal HammerCost;
	public decimal HammerPointsPerSecond;
	public Text HammerLevelTxt;
	public Text HammerCPSTxt;
	public Text HammerCostTxt;

	//Handsaw
	public GameObject btnHandsaw;
	public GameObject imgHandsaw;
	public decimal HandsawLevel;
	public decimal HandsawCPS;
	public decimal HandsawCost;
	public decimal HandsawPointsPerSecond;
	public Text HandsawLevelTxt;
	public Text HandsawCPSTxt;
	public Text HandsawCostTxt;

	//Fence
	public GameObject btnFence;
	public GameObject imgFence;
	public decimal FenceLevel;
	public decimal FenceCPS;
	public decimal FenceCost;
	public decimal FencePointsPerSecond;
	public Text FenceLevelTxt;
	public Text FenceCPSTxt;
	public Text FenceCostTxt;

	//Dog
	public GameObject btnDog;
	public GameObject imgDog;
	public decimal DogLevel;
	public decimal DogCPS;
	public decimal DogCost;
	public decimal DogPointsPerSecond;
	public Text DogLevelTxt;
	public Text DogCPSTxt;
	public Text DogCostTxt;

	//Cat
	public GameObject btnCat;
	public GameObject imgCat;
	public decimal CatLevel;
	public decimal CatCPS;
	public decimal CatCost;
	public decimal CatPointsPerSecond;
	public Text CatLevelTxt;
	public Text CatCPSTxt;
	public Text CatCostTxt;

	//Chicken
	public GameObject btnChicken;
	public GameObject imgChicken;
	public decimal ChickenLevel;
	public decimal ChickenCPS;
	public decimal ChickenCost;
	public decimal ChickenPointsPerSecond;
	public Text ChickenLevelTxt;
	public Text ChickenCPSTxt;
	public Text ChickenCostTxt;

	//Pig
	public GameObject btnPig;
	public GameObject imgPig;
	public decimal PigLevel;
	public decimal PigCPS;
	public decimal PigCost;
	public decimal PigPointsPerSecond;
	public Text PigLevelTxt;
	public Text PigCPSTxt;
	public Text PigCostTxt;

	//Sheep
	public GameObject btnSheep;
	public GameObject imgSheep;
	public decimal SheepLevel;
	public decimal SheepCPS;
	public decimal SheepCost;
	public decimal SheepPointsPerSecond;
	public Text SheepLevelTxt;
	public Text SheepCPSTxt;
	public Text SheepCostTxt;

	//Cow
	public GameObject btnCow;
	public GameObject imgCow;
	public decimal CowLevel;
	public decimal CowCPS;
	public decimal CowCost;
	public decimal CowPointsPerSecond;
	public Text CowLevelTxt;
	public Text CowCPSTxt;
	public Text CowCostTxt;

	//Horse
	public GameObject btnHorse;
	public GameObject imgHorse;
	public decimal HorseLevel;
	public decimal HorseCPS;
	public decimal HorseCost;
	public decimal HorsePointsPerSecond;
	public Text HorseLevelTxt;
	public Text HorseCPSTxt;
	public Text HorseCostTxt;

	//GoldPear
	public GameObject btnGoldPear;
	public GameObject imgGoldPear;
	public decimal GoldPearLevel;
	public decimal GoldPearCPS;
	public decimal GoldPearCost;
	public decimal GoldPearPointsPerSecond;
	public Text GoldPearLevelTxt;
	public Text GoldPearCPSTxt;
	public Text GoldPearCostTxt;

	//Barn
	public GameObject btnBarn;
	public GameObject imgBarn;
	public decimal BarnLevel;
	public decimal BarnCPS;
	public decimal BarnCost;
	public decimal BarnPointsPerSecond;
	public Text BarnLevelTxt;
	public Text BarnCPSTxt;
	public Text BarnCostTxt;

	//Tractor
	public GameObject btnTractor;
	public GameObject imgTractor;
	public decimal TractorLevel;
	public decimal TractorCPS;
	public decimal TractorCost;
	public decimal TractorPointsPerSecond;
	public Text TractorLevelTxt;
	public Text TractorCPSTxt;
	public Text TractorCostTxt;

	//Mill
	public GameObject btnMill;
	public GameObject imgMill;
	public decimal MillLevel;
	public decimal MillCPS;
	public decimal MillCost;
	public decimal MillPointsPerSecond;
	public Text MillLevelTxt;
	public Text MillCPSTxt;
	public Text MillCostTxt;

	//GoldApple
	public GameObject btnGoldApple;
	public GameObject imgGoldApple;
	public decimal GoldAppleLevel;
	public decimal GoldAppleCPS;
	public decimal GoldAppleCost;
	public decimal GoldApplePointsPerSecond;
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
			if (PlayerPrefs.HasKey ("seedsCost") && PlayerPrefs.HasKey ("seedsLevel") && PlayerPrefs.HasKey ("seedsCPS") && PlayerPrefs.HasKey ("seedsPointsPerSecond")) {
				//retreive seeds data and convert it to decimal
				seedsCost = decimal.Parse (PlayerPrefs.GetString("seedsCost"));
				seedsLevel = decimal.Parse (PlayerPrefs.GetString("seedsLevel"));
				seedsCPS = decimal.Parse (PlayerPrefs.GetString("seedsCPS"));
				seedsPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("seedsPointsPerSecond"));
				//add pre-existing seeds data to pointsPerSecond
				pointsPerSecond += seedsPointsPerSecond;
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
			if (PlayerPrefs.HasKey ("flowersCost") && PlayerPrefs.HasKey ("flowersLevel") && PlayerPrefs.HasKey ("flowersCPS") && PlayerPrefs.HasKey ("flowersPointsPerSecond")) {
				//retreive flowers data and convert it to decimal
				flowersCost = decimal.Parse (PlayerPrefs.GetString("flowersCost"));
				flowersLevel = decimal.Parse (PlayerPrefs.GetString("flowersLevel"));
				flowersCPS = decimal.Parse (PlayerPrefs.GetString("flowersCPS"));
				FlowersPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("flowersPointsPerSecond"));
				//add pre-existing flowers data to pointsPerSecond
				pointsPerSecond += FlowersPointsPerSecond;
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
			if (PlayerPrefs.HasKey ("tomatoCost") && PlayerPrefs.HasKey ("tomatoLevel") && PlayerPrefs.HasKey ("tomatoCPS") && PlayerPrefs.HasKey ("tomatoPointsPerSecond")) {
				//retreive tomato data and convert it to decimal
				tomatoCost = decimal.Parse (PlayerPrefs.GetString("tomatoCost"));
				tomatoLevel = decimal.Parse (PlayerPrefs.GetString("tomatoLevel"));
				tomatoCPS = decimal.Parse (PlayerPrefs.GetString("tomatoCPS"));
				TomatoPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("tomatoPointsPerSecond"));
				//add pre-existing tomato data to pointsPerSecond
				pointsPerSecond += TomatoPointsPerSecond;
				imgTomato.SetActive(true);
				//verify to unlock next object
				if (tomatoLevel >= 25) {
					btnTree.GetComponent<Button>().interactable = true;
				} else {
					btnTree.GetComponent<Button>().interactable = false;
				}
				//tomato txt update
				tomatoCPSTxt.text = "C.P.S : " + tomatoCPS;
				tomatoLevelTxt.text = "Level : " + tomatoLevel;
				tomatoCostTxt.text = tomatoCost + "$";
			} 

			//verify if Tree data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("TreeCost") && PlayerPrefs.HasKey ("TreeLevel") && PlayerPrefs.HasKey ("TreeCPS") && PlayerPrefs.HasKey ("TreePointsPerSecond")) {
				//retreive Tree data and convert it to decimal
				TreeCost = decimal.Parse (PlayerPrefs.GetString("TreeCost"));
				TreeLevel = decimal.Parse (PlayerPrefs.GetString("TreeLevel"));
				TreeCPS = decimal.Parse (PlayerPrefs.GetString("TreeCPS"));
				TreePointsPerSecond = decimal.Parse (PlayerPrefs.GetString("TreePointsPerSecond"));
				//add pre-existing Tree data to pointsPerSecond
				pointsPerSecond += TreePointsPerSecond;
				imgTree.SetActive(true);
				//verify to unlock next object
				if (TreeLevel >= 25) {
					btnGreenApple.GetComponent<Button>().interactable = true;
				} else {
					btnGreenApple.GetComponent<Button>().interactable = false;
				}
				//Tree txt update
				TreeCPSTxt.text = "C.P.S : " + TreeCPS;
				TreeLevelTxt.text = "Level : " + TreeLevel;
				TreeCostTxt.text = TreeCost + "$";
			} 

			//verify if GreenApple data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("GreenAppleCost") && PlayerPrefs.HasKey ("GreenAppleLevel") && PlayerPrefs.HasKey ("GreenAppleCPS") && PlayerPrefs.HasKey ("GreenApplePointsPerSecond")) {
				//retreive GreenApple data and convert it to decimal
				GreenAppleCost = decimal.Parse (PlayerPrefs.GetString("GreenAppleCost"));
				GreenAppleLevel = decimal.Parse (PlayerPrefs.GetString("GreenAppleLevel"));
				GreenAppleCPS = decimal.Parse (PlayerPrefs.GetString("GreenAppleCPS"));
				GreenApplePointsPerSecond = decimal.Parse (PlayerPrefs.GetString("GreenApplePointsPerSecond"));
				//add pre-existing GreenApple data to pointsPerSecond
				pointsPerSecond += GreenApplePointsPerSecond;
				imgGreenApple.SetActive(true);
				//verify to unlock next object
				if (GreenAppleLevel >= 25) {
					btnCarrot.GetComponent<Button>().interactable = true;
				} else {
					btnCarrot.GetComponent<Button>().interactable = false;
				}
				//GreenApple txt update
				GreenAppleCPSTxt.text = "C.P.S : " + GreenAppleCPS;
				GreenAppleLevelTxt.text = "Level : " + GreenAppleLevel;
				GreenAppleCostTxt.text = GreenAppleCost + "$";
			} 

			//verify if Carrot data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("CarrotCost") && PlayerPrefs.HasKey ("CarrotLevel") && PlayerPrefs.HasKey ("CarrotCPS") && PlayerPrefs.HasKey ("CarrotPointsPerSecond")) {
				//retreive Carrot data and convert it to decimal
				CarrotCost = decimal.Parse (PlayerPrefs.GetString("CarrotCost"));
				CarrotLevel = decimal.Parse (PlayerPrefs.GetString("CarrotLevel"));
				CarrotCPS = decimal.Parse (PlayerPrefs.GetString("CarrotCPS"));
				CarrotPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("CarrotPointsPerSecond"));
				//add pre-existing Carrot data to pointsPerSecond
				pointsPerSecond += CarrotPointsPerSecond;
				imgCarrot.SetActive(true);
				//verify to unlock next object
				if (CarrotLevel >= 25) {
					btnGreenPear.GetComponent<Button>().interactable = true;
				} else {
					btnGreenPear.GetComponent<Button>().interactable = false;
				}
				//Carrot txt update
				CarrotCPSTxt.text = "C.P.S : " + CarrotCPS;
				CarrotLevelTxt.text = "Level : " + CarrotLevel;
				CarrotCostTxt.text = CarrotCost + "$";
			} 

			//verify if GreenPear data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("GreenPearCost") && PlayerPrefs.HasKey ("GreenPearLevel") && PlayerPrefs.HasKey ("GreenPearCPS") && PlayerPrefs.HasKey ("GreenPearPointsPerSecond")) {
				//retreive GreenPear data and convert it to decimal
				GreenPearCost = decimal.Parse (PlayerPrefs.GetString("GreenPearCost"));
				GreenPearLevel = decimal.Parse (PlayerPrefs.GetString("GreenPearLevel"));
				GreenPearCPS = decimal.Parse (PlayerPrefs.GetString("GreenPearCPS"));
				GreenPearPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("GreenPearPointsPerSecond"));
				//add pre-existing GreenPear data to pointsPerSecond
				pointsPerSecond += GreenPearPointsPerSecond;
				imgGreenPear.SetActive(true);
				//verify to unlock next object
				if (GreenPearLevel >= 25) {
					btnCorn.GetComponent<Button>().interactable = true;
				} else {
					btnCorn.GetComponent<Button>().interactable = false;
				}
				//GreenPear txt update
				GreenPearCPSTxt.text = "C.P.S : " + GreenPearCPS;
				GreenPearLevelTxt.text = "Level : " + GreenPearLevel;
				GreenPearCostTxt.text = GreenPearCost + "$";
			} 

			//verify if Corn data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("CornCost") && PlayerPrefs.HasKey ("CornLevel") && PlayerPrefs.HasKey ("CornCPS") && PlayerPrefs.HasKey ("CornPointsPerSecond")) {
				//retreive Corn data and convert it to decimal
				CornCost = decimal.Parse (PlayerPrefs.GetString("CornCost"));
				CornLevel = decimal.Parse (PlayerPrefs.GetString("CornLevel"));
				CornCPS = decimal.Parse (PlayerPrefs.GetString("CornCPS"));
				CornPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("CornPointsPerSecond"));
				//add pre-existing Corn data to pointsPerSecond
				pointsPerSecond += CornPointsPerSecond;
				imgCorn.SetActive(true);
				//verify to unlock next object
				if (CornLevel >= 25) {
					btnRedApple.GetComponent<Button>().interactable = true;
				} else {
					btnRedApple.GetComponent<Button>().interactable = false;
				}
				//Corn txt update
				CornCPSTxt.text = "C.P.S : " + CornCPS;
				CornLevelTxt.text = "Level : " + CornLevel;
				CornCostTxt.text = CornCost + "$";
			} 

			//verify if RedApple data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("RedAppleCost") && PlayerPrefs.HasKey ("RedAppleLevel") && PlayerPrefs.HasKey ("RedAppleCPS") && PlayerPrefs.HasKey ("RedApplePointsPerSecond")) {
				//retreive RedApple data and convert it to decimal
				RedAppleCost = decimal.Parse (PlayerPrefs.GetString("RedAppleCost"));
				RedAppleLevel = decimal.Parse (PlayerPrefs.GetString("RedAppleLevel"));
				RedAppleCPS = decimal.Parse (PlayerPrefs.GetString("RedAppleCPS"));
				RedApplePointsPerSecond = decimal.Parse (PlayerPrefs.GetString("RedApplePointsPerSecond"));
				//add pre-existing RedApple data to pointsPerSecond
				pointsPerSecond += RedApplePointsPerSecond;
				imgRedApple.SetActive(true);
				//verify to unlock next object
				if (RedAppleLevel >= 25) {
					btnWatermelon.GetComponent<Button>().interactable = true;
				} else {
					btnWatermelon.GetComponent<Button>().interactable = false;
				}
				//RedApple txt update
				RedAppleCPSTxt.text = "C.P.S : " + RedAppleCPS;
				RedAppleLevelTxt.text = "Level : " + RedAppleLevel;
				RedAppleCostTxt.text = RedAppleCost + "$";
			} 

			//verify if Watermelon data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("WatermelonCost") && PlayerPrefs.HasKey ("WatermelonLevel") && PlayerPrefs.HasKey ("WatermelonCPS") && PlayerPrefs.HasKey ("WatermelonPointsPerSecond")) {
				//retreive Watermelon data and convert it to decimal
				WatermelonCost = decimal.Parse (PlayerPrefs.GetString("WatermelonCost"));
				WatermelonLevel = decimal.Parse (PlayerPrefs.GetString("WatermelonLevel"));
				WatermelonCPS = decimal.Parse (PlayerPrefs.GetString("WatermelonCPS"));
				WatermelonPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("WatermelonPointsPerSecond"));
				//add pre-existing Watermelon data to pointsPerSecond
				pointsPerSecond += WatermelonPointsPerSecond;
				imgWatermelon.SetActive(true);
				//verify to unlock next object
				if (WatermelonLevel >= 25) {
					btnRedPear.GetComponent<Button>().interactable = true;
				} else {
					btnRedPear.GetComponent<Button>().interactable = false;
				}
				//Watermelon txt update
				WatermelonCPSTxt.text = "C.P.S : " + WatermelonCPS;
				WatermelonLevelTxt.text = "Level : " + WatermelonLevel;
				WatermelonCostTxt.text = WatermelonCost + "$";
			} 

			//verify if RedPear data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("RedPearCost") && PlayerPrefs.HasKey ("RedPearLevel") && PlayerPrefs.HasKey ("RedPearCPS") && PlayerPrefs.HasKey ("RedPearPointsPerSecond")) {
				//retreive RedPear data and convert it to decimal
				RedPearCost = decimal.Parse (PlayerPrefs.GetString("RedPearCost"));
				RedPearLevel = decimal.Parse (PlayerPrefs.GetString("RedPearLevel"));
				RedPearCPS = decimal.Parse (PlayerPrefs.GetString("RedPearCPS"));
				RedPearPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("RedPearPointsPerSecond"));
				//add pre-existing RedPear data to pointsPerSecond
				pointsPerSecond += RedPearPointsPerSecond;
				imgRedPear.SetActive(true);
				//verify to unlock next object
				if (RedPearLevel >= 25) {
					btnPumpkin.GetComponent<Button>().interactable = true;
				} else {
					btnPumpkin.GetComponent<Button>().interactable = false;
				}
				//RedPear txt update
				RedPearCPSTxt.text = "C.P.S : " + RedPearCPS;
				RedPearLevelTxt.text = "Level : " + RedPearLevel;
				RedPearCostTxt.text = RedPearCost + "$";
			} 

			//verify if Pumpkin data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("PumpkinCost") && PlayerPrefs.HasKey ("PumpkinLevel") && PlayerPrefs.HasKey ("PumpkinCPS") && PlayerPrefs.HasKey ("PumpkinPointsPerSecond")) {
				//retreive Pumpkin data and convert it to decimal
				PumpkinCost = decimal.Parse (PlayerPrefs.GetString("PumpkinCost"));
				PumpkinLevel = decimal.Parse (PlayerPrefs.GetString("PumpkinLevel"));
				PumpkinCPS = decimal.Parse (PlayerPrefs.GetString("PumpkinCPS"));
				PumpkinPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("PumpkinPointsPerSecond"));
				//add pre-existing Pumpkin data to pointsPerSecond
				pointsPerSecond += PumpkinPointsPerSecond;
				imgPumpkin.SetActive(true);
				//verify to unlock next object
				if (PumpkinLevel >= 25) {
					btnWrench.GetComponent<Button>().interactable = true;
				} else {
					btnWrench.GetComponent<Button>().interactable = false;
				}
				//Pumpkin txt update
				PumpkinCPSTxt.text = "C.P.S : " + PumpkinCPS;
				PumpkinLevelTxt.text = "Level : " + PumpkinLevel;
				PumpkinCostTxt.text = PumpkinCost + "$";
			} 

			//verify if Wrench data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("WrenchCost") && PlayerPrefs.HasKey ("WrenchLevel") && PlayerPrefs.HasKey ("WrenchCPS") && PlayerPrefs.HasKey ("WrenchPointsPerSecond")) {
				//retreive Wrench data and convert it to decimal
				WrenchCost = decimal.Parse (PlayerPrefs.GetString("WrenchCost"));
				WrenchLevel = decimal.Parse (PlayerPrefs.GetString("WrenchLevel"));
				WrenchCPS = decimal.Parse (PlayerPrefs.GetString("WrenchCPS"));
				WrenchPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("WrenchPointsPerSecond"));
				//add pre-existing Wrench data to pointsPerSecond
				pointsPerSecond += WrenchPointsPerSecond;
				imgWrench.SetActive(true);
				//verify to unlock next object
				if (WrenchLevel >= 25) {
					btnScrewdriver.GetComponent<Button>().interactable = true;
				} else {
					btnScrewdriver.GetComponent<Button>().interactable = false;
				}
				//Wrench txt update
				WrenchCPSTxt.text = "C.P.S : " + WrenchCPS;
				WrenchLevelTxt.text = "Level : " + WrenchLevel;
				WrenchCostTxt.text = WrenchCost + "$";
			} 

			//verify if Screwdriver data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("ScrewdriverCost") && PlayerPrefs.HasKey ("ScrewdriverLevel") && PlayerPrefs.HasKey ("ScrewdriverCPS") && PlayerPrefs.HasKey ("ScrewdriverPointsPerSecond")) {
				//retreive Screwdriver data and convert it to decimal
				ScrewdriverCost = decimal.Parse (PlayerPrefs.GetString("ScrewdriverCost"));
				ScrewdriverLevel = decimal.Parse (PlayerPrefs.GetString("ScrewdriverLevel"));
				ScrewdriverCPS = decimal.Parse (PlayerPrefs.GetString("ScrewdriverCPS"));
				ScrewdriverPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("ScrewdriverPointsPerSecond"));
				//add pre-existing Screwdriver data to pointsPerSecond
				pointsPerSecond += ScrewdriverPointsPerSecond;
				imgScrewdriver.SetActive(true);
				//verify to unlock next object
				if (ScrewdriverLevel >= 25) {
					btnHammer.GetComponent<Button>().interactable = true;
				} else {
					btnHammer.GetComponent<Button>().interactable = false;
				}
				//Screwdriver txt update
				ScrewdriverCPSTxt.text = "C.P.S : " + ScrewdriverCPS;
				ScrewdriverLevelTxt.text = "Level : " + ScrewdriverLevel;
				ScrewdriverCostTxt.text = ScrewdriverCost + "$";
			} 

			//verify if Hammer data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("HammerCost") && PlayerPrefs.HasKey ("HammerLevel") && PlayerPrefs.HasKey ("HammerCPS") && PlayerPrefs.HasKey ("HammerPointsPerSecond")) {
				//retreive Hammer data and convert it to decimal
				HammerCost = decimal.Parse (PlayerPrefs.GetString("HammerCost"));
				HammerLevel = decimal.Parse (PlayerPrefs.GetString("HammerLevel"));
				HammerCPS = decimal.Parse (PlayerPrefs.GetString("HammerCPS"));
				HammerPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("HammerPointsPerSecond"));
				//add pre-existing Hammer data to pointsPerSecond
				pointsPerSecond += HammerPointsPerSecond;
				imgHammer.SetActive(true);
				//verify to unlock next object
				if (HammerLevel >= 25) {
					btnHandsaw.GetComponent<Button>().interactable = true;
				} else {
					btnHandsaw.GetComponent<Button>().interactable = false;
				}
				//Hammer txt update
				HammerCPSTxt.text = "C.P.S : " + HammerCPS;
				HammerLevelTxt.text = "Level : " + HammerLevel;
				HammerCostTxt.text = HammerCost + "$";
			} 

			//verify if Handsaw data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("HandsawCost") && PlayerPrefs.HasKey ("HandsawLevel") && PlayerPrefs.HasKey ("HandsawCPS") && PlayerPrefs.HasKey ("HandsawPointsPerSecond")) {
				//retreive Handsaw data and convert it to decimal
				HandsawCost = decimal.Parse (PlayerPrefs.GetString("HandsawCost"));
				HandsawLevel = decimal.Parse (PlayerPrefs.GetString("HandsawLevel"));
				HandsawCPS = decimal.Parse (PlayerPrefs.GetString("HandsawCPS"));
				HandsawPointsPerSecond = decimal.Parse (PlayerPrefs.GetString("HandsawPointsPerSecond"));
				//add pre-existing Handsaw data to pointsPerSecond
				pointsPerSecond += HandsawPointsPerSecond;
				imgHandsaw.SetActive(true);
				//verify to unlock next object
				if (HandsawLevel >= 25) {
					btnFence.GetComponent<Button>().interactable = true;
				} else {
					btnFence.GetComponent<Button>().interactable = false;
				}
				//Handsaw txt update
				HandsawCPSTxt.text = "C.P.S : " + HandsawCPS;
				HandsawLevelTxt.text = "Level : " + HandsawLevel;
				HandsawCostTxt.text = HandsawCost + "$";
			} 

			//verify if Fence data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("FenceCost") && PlayerPrefs.HasKey ("FenceLevel") && PlayerPrefs.HasKey ("FenceCPS") && PlayerPrefs.HasKey ("FencePointsPerSecond")) {
				//retreive Fence data and convert it to decimal
				FenceCost = decimal.Parse (PlayerPrefs.GetString("FenceCost"));
				FenceLevel = decimal.Parse (PlayerPrefs.GetString("FenceLevel"));
				FenceCPS = decimal.Parse (PlayerPrefs.GetString("FenceCPS"));
				FencePointsPerSecond = decimal.Parse (PlayerPrefs.GetString("FencePointsPerSecond"));
				//add pre-existing Fence data to pointsPerSecond
				pointsPerSecond += FencePointsPerSecond;
				imgFence.SetActive(true);
				//verify to unlock next object
				if (FenceLevel >= 25) {
					btnDog.GetComponent<Button>().interactable = true;
				} else {
					btnDog.GetComponent<Button>().interactable = false;
				}
				//Fence txt update
				FenceCPSTxt.text = "C.P.S : " + FenceCPS;
				FenceLevelTxt.text = "Level : " + FenceLevel;
				FenceCostTxt.text = FenceCost + "$";
			} 
			//======================================================================================================================================================================
			//======================================================================================================================================================================
			//======================================================================================================================================================================
			//======================================================================================================================================================================
			//======================================================================================================================================================================
			//verify if Dog data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("Cost") && PlayerPrefs.HasKey ("Level") && PlayerPrefs.HasKey ("CPS") && PlayerPrefs.HasKey ("PointsPerSecond")) {
				//retreive Dog data and convert it to decimal
				Cost = decimal.Parse (PlayerPrefs.GetString("Cost"));
				Level = decimal.Parse (PlayerPrefs.GetString("Level"));
				CPS = decimal.Parse (PlayerPrefs.GetString("CPS"));
				PointsPerSecond = decimal.Parse (PlayerPrefs.GetString("PointsPerSecond"));
				//add pre-existing Dog data to pointsPerSecond
				pointsPerSecond += PointsPerSecond;
				img.SetActive(true);
				//verify to unlock next object
				if (Level >= 25) {
					btn.GetComponent<Button>().interactable = true;
				} else {
					btn.GetComponent<Button>().interactable = false;
				}
				//Dog txt update
				CPSTxt.text = "C.P.S : " + CPS;
				LevelTxt.text = "Level : " + Level;
				CostTxt.text = Cost + "$";
			} 

			//verify if  data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("Cost") && PlayerPrefs.HasKey ("Level") && PlayerPrefs.HasKey ("CPS") && PlayerPrefs.HasKey ("PointsPerSecond")) {
				//retreive  data and convert it to decimal
				Cost = decimal.Parse (PlayerPrefs.GetString("Cost"));
				Level = decimal.Parse (PlayerPrefs.GetString("Level"));
				CPS = decimal.Parse (PlayerPrefs.GetString("CPS"));
				PointsPerSecond = decimal.Parse (PlayerPrefs.GetString("PointsPerSecond"));
				//add pre-existing  data to pointsPerSecond
				pointsPerSecond += PointsPerSecond;
				img.SetActive(true);
				//verify to unlock next object
				if (Level >= 25) {
					btn.GetComponent<Button>().interactable = true;
				} else {
					btn.GetComponent<Button>().interactable = false;
				}
				// txt update
				CPSTxt.text = "C.P.S : " + CPS;
				LevelTxt.text = "Level : " + Level;
				CostTxt.text = Cost + "$";
			} 

			//verify if  data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("Cost") && PlayerPrefs.HasKey ("Level") && PlayerPrefs.HasKey ("CPS") && PlayerPrefs.HasKey ("PointsPerSecond")) {
				//retreive  data and convert it to decimal
				Cost = decimal.Parse (PlayerPrefs.GetString("Cost"));
				Level = decimal.Parse (PlayerPrefs.GetString("Level"));
				CPS = decimal.Parse (PlayerPrefs.GetString("CPS"));
				PointsPerSecond = decimal.Parse (PlayerPrefs.GetString("PointsPerSecond"));
				//add pre-existing  data to pointsPerSecond
				pointsPerSecond += PointsPerSecond;
				img.SetActive(true);
				//verify to unlock next object
				if (Level >= 25) {
					btn.GetComponent<Button>().interactable = true;
				} else {
					btn.GetComponent<Button>().interactable = false;
				}
				// txt update
				CPSTxt.text = "C.P.S : " + CPS;
				LevelTxt.text = "Level : " + Level;
				CostTxt.text = Cost + "$";
			} 

			//verify if  data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("Cost") && PlayerPrefs.HasKey ("Level") && PlayerPrefs.HasKey ("CPS") && PlayerPrefs.HasKey ("PointsPerSecond")) {
				//retreive  data and convert it to decimal
				Cost = decimal.Parse (PlayerPrefs.GetString("Cost"));
				Level = decimal.Parse (PlayerPrefs.GetString("Level"));
				CPS = decimal.Parse (PlayerPrefs.GetString("CPS"));
				PointsPerSecond = decimal.Parse (PlayerPrefs.GetString("PointsPerSecond"));
				//add pre-existing  data to pointsPerSecond
				pointsPerSecond += PointsPerSecond;
				img.SetActive(true);
				//verify to unlock next object
				if (Level >= 25) {
					btn.GetComponent<Button>().interactable = true;
				} else {
					btn.GetComponent<Button>().interactable = false;
				}
				// txt update
				CPSTxt.text = "C.P.S : " + CPS;
				LevelTxt.text = "Level : " + Level;
				CostTxt.text = Cost + "$";
			} 

			//verify if  data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("Cost") && PlayerPrefs.HasKey ("Level") && PlayerPrefs.HasKey ("CPS") && PlayerPrefs.HasKey ("PointsPerSecond")) {
				//retreive  data and convert it to decimal
				Cost = decimal.Parse (PlayerPrefs.GetString("Cost"));
				Level = decimal.Parse (PlayerPrefs.GetString("Level"));
				CPS = decimal.Parse (PlayerPrefs.GetString("CPS"));
				PointsPerSecond = decimal.Parse (PlayerPrefs.GetString("PointsPerSecond"));
				//add pre-existing  data to pointsPerSecond
				pointsPerSecond += PointsPerSecond;
				img.SetActive(true);
				//verify to unlock next object
				if (Level >= 25) {
					btn.GetComponent<Button>().interactable = true;
				} else {
					btn.GetComponent<Button>().interactable = false;
				}
				// txt update
				CPSTxt.text = "C.P.S : " + CPS;
				LevelTxt.text = "Level : " + Level;
				CostTxt.text = Cost + "$";
			} 

			//verify if  data already exist in PlayerPrefs
			if (PlayerPrefs.HasKey ("Cost") && PlayerPrefs.HasKey ("Level") && PlayerPrefs.HasKey ("CPS") && PlayerPrefs.HasKey ("PointsPerSecond")) {
				//retreive  data and convert it to decimal
				Cost = decimal.Parse (PlayerPrefs.GetString("Cost"));
				Level = decimal.Parse (PlayerPrefs.GetString("Level"));
				CPS = decimal.Parse (PlayerPrefs.GetString("CPS"));
				PointsPerSecond = decimal.Parse (PlayerPrefs.GetString("PointsPerSecond"));
				//add pre-existing  data to pointsPerSecond
				pointsPerSecond += PointsPerSecond;
				img.SetActive(true);
				//verify to unlock next object
				if (Level >= 25) {
					btn.GetComponent<Button>().interactable = true;
				} else {
					btn.GetComponent<Button>().interactable = false;
				}
				// txt update
				CPSTxt.text = "C.P.S : " + CPS;
				LevelTxt.text = "Level : " + Level;
				CostTxt.text = Cost + "$";
			} 







		} else {	//Show welcome message at first launch
			WelcomeActive = true;
			panelWelcome.SetActive (true);

			//set seeds default values
			seedsCost = 5;
			seedsLevel = 0;
			seedsCPS = 0;
			//seeds txt update
			seedsCPSTxt.text = "C.P.S : " + seedsCPS;
			seedsLevelTxt.text = "Level : " + seedsLevel;
			seedsCostTxt.text = seedsCost + "$";

			//set flowers default values
			flowersCost = 1000;
			flowersLevel = 0;
			flowersCPS = 3;
			//lock flowers
			btnFlowers.GetComponent<Button>().interactable = false;
			//flowers txt update
			flowersCPSTxt.text = "C.P.S : " + flowersCPS;
			flowersLevelTxt.text = "Level : " + flowersLevel;
			flowersCostTxt.text = flowersCost + "$"; 
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

	//Recalculate pointsPerSecond
	public void RecalPtsPerSec () {
		pointsPerSecond = seedsPointsPerSecond + FlowersPointsPerSecond + TomatoPointsPerSecond + TreePointsPerSecond + GreenApplePointsPerSecond + CarrotPointsPerSecond + GreenPearPointsPerSecond + CornPointsPerSecond + RedApplePointsPerSecond + WatermelonPointsPerSecond + RedPearPointsPerSecond + PumpkinPointsPerSecond + WrenchPointsPerSecond + ScrewdriverPointsPerSecond + HammerPointsPerSecond + HandsawPointsPerSecond + FencePointsPerSecond + DogPointsPerSecond + CatPointsPerSecond + ChickenPointsPerSecond + PigPointsPerSecond + SheepPointsPerSecond + CowPointsPerSecond + HorsePointsPerSecond + GoldPearPointsPerSecond + BarnPointsPerSecond + TractorPointsPerSecond + MillPointsPerSecond + GoldApplePointsPerSecond;
	}
		
	//-------------------------------------------------  Shop  -------------------------------------------------
	//--------------------------  seeds  --------------------------
	public void BuySeeds () {
		//check for the money available
		if (scoreCount >= seedsCost) {
			scoreCount -= seedsCost;
			seedsLevel += 1;
			seedsCPS = seedsCPS + 1;
			seedsPointsPerSecond = seedsCPS;
			seedsCost += 25;
			imgSeeds.SetActive(true);
		}
		//cheat for developper
		//if (seedsLevel > 3) {
		//	pointsPerSecond += 10000000000000000000;
		//}
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
		string seedsPointsPerSecondSave = seedsPointsPerSecond.ToString ();
		//save seeds data to PlayerPrefs
		PlayerPrefs.SetString ("seedsCPS", seedsCPSSave);
		PlayerPrefs.SetString ("seedsLevel", seedsLevelSave);
		PlayerPrefs.SetString ("seedsCost", seedsCostSave);
		PlayerPrefs.SetString ("seedsPointsPerSecond", seedsPointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  flowers  --------------------------
	public void BuyFlowers () {
		if (Level >= 25) {
			//check for the money available
			if (scoreCount >= Cost) {
				scoreCount -= Cost;
				Level += 1;
				CPS = CPS + 1;
				PointsPerSecond = CPS;
				Cost += 25;
				img.SetActive(true);
			}
		}
		//enable the 
		if (Level >= 25) {
			btn.GetComponent<Button>().interactable = true;
		}
		// txt update
		CPSTxt.text = "C.P.S : " + CPS;
		LevelTxt.text = "Level : " + Level;
		CostTxt.text = Cost + "$";
		//convert  data to string to save in PlayerPrefs
		string CPSSave = CPS.ToString ();
		string LevelSave = Level.ToString ();
		string CostSave = Cost.ToString ();
		string PointsPerSecondSave = PointsPerSecond.ToString ();
		//save  data to PlayerPrefs
		PlayerPrefs.SetString ("CPS", seedsCPSSave);
		PlayerPrefs.SetString ("Level", seedsLevelSave);
		PlayerPrefs.SetString ("Cost", seedsCostSave);
		PlayerPrefs.SetString ("PointsPerSecond", seedsPointsPerSecondSave);
		//go refresh the pointsPerSecond
		Invoke ("RecalPtsPerSec", 0f);
	}

	//--------------------------  tomato  --------------------------
	public void BuyTomato () {
		
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
