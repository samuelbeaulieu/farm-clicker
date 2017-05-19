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

	//seeds
	public float seedsLevel;
	public decimal seedsCPS;
	public int seedsCost;
	public Text seedsLevelTxt;
	public Text seedsCPSTxt;
	public Text seedsCostTxt;

	//flowers
	public float flowersLevel;
	public decimal flowersCPS;
	public int flowersCost;
	public Text flowersLevelTxt;
	public Text flowersCPSTxt;
	public Text flowersCostTxt;

	//tomato
	public float tomatoLevel;
	public decimal tomatoCPS;
	public int tomatoCost;
	public Text tomatoLevelTxt;
	public Text tomatoCPSTxt;
	public Text tomatoCostTxt;

	//GreenApple
	public float GreenAppleLevel;
	public decimal GreenAppleCPS;
	public int GreenAppleCost;
	public Text GreenAppleLevelTxt;
	public Text GreenAppleCPSTxt;
	public Text GreenAppleCostTxt;

	//Carrot
	public float CarrotLevel;
	public decimal CarrotCPS;
	public int CarrotCost;
	public Text CarrotLevelTxt;
	public Text CarrotCPSTxt;
	public Text CarrotCostTxt;

	//GreenPear
	public float GreenPearLevel;
	public decimal GreenPearCPS;
	public int GreenPearCost;
	public Text GreenPearLevelTxt;
	public Text GreenPearCPSTxt;
	public Text GreenPearCostTxt;

	//Corn
	public float CornLevel;
	public decimal CornCPS;
	public int CornCost;
	public Text CornLevelTxt;
	public Text CornCPSTxt;
	public Text CornCostTxt;

	//RedApple
	public float RedAppleLevel;
	public decimal RedAppleCPS;
	public int RedAppleCost;
	public Text RedAppleLevelTxt;
	public Text RedAppleCPSTxt;
	public Text RedAppleCostTxt;

	//Watermelon
	public float WatermelonLevel;
	public decimal WatermelonCPS;
	public int WatermelonCost;
	public Text WatermelonLevelTxt;
	public Text WatermelonCPSTxt;
	public Text WatermelonCostTxt;

	//RedPear
	public float RedPearLevel;
	public decimal RedPearCPS;
	public int RedPearCost;
	public Text RedPearLevelTxt;
	public Text RedPearCPSTxt;
	public Text RedPearCostTxt;

	//Pumpkin
	public float PumpkinLevel;
	public decimal PumpkinCPS;
	public int PumpkinCost;
	public Text PumpkinLevelTxt;
	public Text PumpkinCPSTxt;
	public Text PumpkinCostTxt;

	//Wrench
	public float WrenchLevel;
	public decimal WrenchCPS;
	public int WrenchCost;
	public Text WrenchLevelTxt;
	public Text WrenchCPSTxt;
	public Text WrenchCostTxt;

	//Screwdriver
	public float ScrewdriverLevel;
	public decimal ScrewdriverCPS;
	public int ScrewdriverCost;
	public Text ScrewdriverLevelTxt;
	public Text ScrewdriverCPSTxt;
	public Text ScrewdriverCostTxt;

	//Hammer
	public float HammerLevel;
	public decimal HammerCPS;
	public int HammerCost;
	public Text HammerLevelTxt;
	public Text HammerCPSTxt;
	public Text HammerCostTxt;

	//Handsaw
	public float Level;
	public decimal CPS;
	public int Cost;
	public Text LevelTxt;
	public Text CPSTxt;
	public Text CostTxt;

	//Fence
	public float FenceLevel;
	public decimal FenceCPS;
	public int FenceCost;
	public Text FenceLevelTxt;
	public Text FenceCPSTxt;
	public Text FenceCostTxt;

	//Tree
	public float TreeLevel;
	public decimal TreeCPS;
	public int TreeCost;
	public Text TreeLevelTxt;
	public Text TreeCPSTxt;
	public Text TreeCostTxt;

	//Dog
	public float DogLevel;
	public decimal DogCPS;
	public int DogCost;
	public Text DogLevelTxt;
	public Text DogCPSTxt;
	public Text DogCostTxt;

	//Cat
	public float CatLevel;
	public decimal CatCPS;
	public int CatCost;
	public Text CatLevelTxt;
	public Text CatCPSTxt;
	public Text CatCostTxt;

	//Chicken
	public float ChickenLevel;
	public decimal ChickenCPS;
	public int ChickenCost;
	public Text ChickenLevelTxt;
	public Text ChickenCPSTxt;
	public Text ChickenCostTxt;

	//Pig
	public float PigLevel;
	public decimal PigCPS;
	public int PigCost;
	public Text PigLevelTxt;
	public Text PigCPSTxt;
	public Text PigCostTxt;

	//Sheep
	public float SheepLevel;
	public decimal SheepCPS;
	public int SheepCost;
	public Text SheepLevelTxt;
	public Text SheepCPSTxt;
	public Text SheepCostTxt;

	//Cow
	public float CowLevel;
	public decimal CowCPS;
	public int CowCost;
	public Text CowLevelTxt;
	public Text CowCPSTxt;
	public Text CowCostTxt;

	//Horse
	public float HorseLevel;
	public decimal HorseCPS;
	public int HorseCost;
	public Text HorseLevelTxt;
	public Text HorseCPSTxt;
	public Text HorseCostTxt;

	//GoldPear
	public float GoldPearLevel;
	public decimal GoldPearCPS;
	public int GoldPearCost;
	public Text GoldPearLevelTxt;
	public Text GoldPearCPSTxt;
	public Text GoldPearCostTxt;

	//Barn
	public float BarnLevel;
	public decimal BarnCPS;
	public int BarnCost;
	public Text BarnLevelTxt;
	public Text BarnCPSTxt;
	public Text BarnCostTxt;

	//Tractor
	public float TractorLevel;
	public decimal TractorCPS;
	public int TractorCost;
	public Text TractorLevelTxt;
	public Text TractorCPSTxt;
	public Text TractorCostTxt;

	//Mill
	public float MillLevel;
	public decimal MillCPS;
	public int MillCost;
	public Text MillLevelTxt;
	public Text MillCPSTxt;
	public Text MillCostTxt;

	//GoldApple
	public float GoldAppleLevel;
	public decimal GoldAppleCPS;
	public int GoldAppleCost;
	public Text GoldAppleLevelTxt;
	public Text GoldAppleCPSTxt;
	public Text GoldAppleCostTxt;

	//notepad screens
	public GameObject imgNotepad;
	public GameObject scrollViewTask;
	public GameObject scrollViewShop;
	public bool TaskActive = false;
	public bool ShopActive = false;

	public AudioClip clickMoney;
	AudioSource m_source;

	void Start () {
		m_source = gameObject.GetComponent<AudioSource>();
		//verify if value already exist in PlayerPrefs
		if (PlayerPrefs.HasKey ("Score")) {
			scoreCount = decimal.Parse (PlayerPrefs.GetString("Score"));
		}
		pointsPerTouch = 0;
		pointsPerTouch2 = 1;

		//seeds txt update
		seedsCost = 3;
		seedsLevel = 0;
		seedsCPS = 1;
		seedsCPSTxt.text = "C.P.S : " + seedsCPS;
		seedsLevelTxt.text = "Level : " + seedsLevel;
		seedsCostTxt.text = seedsCost + "$";

		//flowers txt update
		flowersCost = 9;
		flowersLevel = 0;
		flowersCPS = 3;
		flowersCPSTxt.text = "C.P.S : " + flowersCPS;
		flowersLevelTxt.text = "Level : " + flowersLevel;
		flowersCostTxt.text = flowersCost + "$";

		//tomato txt update
		tomatoCost = 15;
		tomatoLevel = 0;
		tomatoCPS = 5;
		tomatoCPSTxt.text = "C.P.S : " + tomatoCPS;
		tomatoLevelTxt.text = "Level : " + tomatoLevel;
		tomatoCostTxt.text = tomatoCost + "$";
	}

	void Update () {
		//detect a mouse clcik
		if (Input.GetMouseButtonDown(0) && TaskActive == false && ShopActive == false) {
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
			seedsCPS += 1;
			pointsPerSecond += seedsCPS;
			seedsCost = Mathf.RoundToInt (seedsCost * Mathf.Pow (1.15f, seedsLevel));
		}
		//seeds txt update
		seedsCPSTxt.text = "C.P.S : " + seedsCPS;
		seedsLevelTxt.text = "Level : " + seedsLevel;
		seedsCostTxt.text = seedsCost + "$";
	}

	public void BuyFlowers () {
		if (scoreCount >= flowersCost) {
			scoreCount -= flowersCost;
			flowersLevel += 1;
			flowersCPS += 3;
			pointsPerSecond += flowersCPS;
			flowersCost = Mathf.RoundToInt (flowersCost * Mathf.Pow (1.35f, flowersLevel));
		}
		//flowers txt update
		flowersCPSTxt.text = "C.P.S : " + flowersCPS;
		flowersLevelTxt.text = "Level : " + flowersLevel;
		flowersCostTxt.text = flowersCost + "$";
	}

	public void BuyTomato () {
		if (scoreCount >= tomatoCost) {
			scoreCount -= tomatoCost;
			tomatoLevel += 1;
			tomatoCPS += 3;
			pointsPerSecond += tomatoCPS;
			tomatoCost = Mathf.RoundToInt (tomatoCost * Mathf.Pow (1.55f, tomatoLevel));
		}
		//tomato txt update
		tomatoCPSTxt.text = "C.P.S : " + tomatoCPS;
		tomatoLevelTxt.text = "Level : " + tomatoLevel;
		tomatoCostTxt.text = tomatoCost + "$";
	}

	public void BuyGreenApple () {
		if (scoreCount >= GreenAppleCost) {
			scoreCount -= GreenAppleCost;
			GreenAppleLevel += 1;
			GreenAppleCPS += 3;
			pointsPerSecond += GreenAppleCPS;
			GreenAppleCost = Mathf.RoundToInt (GreenAppleCost * Mathf.Pow (1.75f, GreenAppleLevel));
		}
		//GreenApple txt update
		GreenAppleCPSTxt.text = "C.P.S : " + GreenAppleCPS;
		GreenAppleLevelTxt.text = "Level : " + GreenAppleLevel;
		GreenAppleCostTxt.text = GreenAppleCost + "$";
	}

	public void Buy () {
		if (scoreCount >= Cost) {
			scoreCount -= Cost;
			Level += 1;
			CPS += 3;
			pointsPerSecond += CPS;
			Cost = Mathf.RoundToInt (Cost * Mathf.Pow (1.55f, Level));
		}
		//tomato txt update
		CPSTxt.text = "C.P.S : " + CPS;
		LevelTxt.text = "Level : " + Level;
		CostTxt.text = Cost + "$";
	}
}
