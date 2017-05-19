using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsMovement : MonoBehaviour {

	public List<Sprite> ListCloud1;
	public SpriteRenderer CloudRenderer1;
	public List<Sprite> ListCloud2;
	public SpriteRenderer CloudRenderer2;
	public List<Sprite> ListCloud3;
	public SpriteRenderer CloudRenderer3;
	public List<Sprite> ListCloud4;
	public SpriteRenderer CloudRenderer4;
	public List<Sprite> ListCloud5;
	public SpriteRenderer CloudRenderer5;
	public GameObject Cloud1;
	public GameObject Cloud2;
	public GameObject Cloud3;
	public GameObject Cloud4;
	public GameObject Cloud5;
	public float CloudStart1;
	public float CloudStart2;
	public float CloudStart3;
	public float CloudStart4;
	public float CloudStart5;
	public int RandomCloud1;
	public int RandomCloud2;
	public int RandomCloud3;
	public int RandomCloud4;
	public int RandomCloud5;
	public float RandomCloudStart1;
	public float RandomCloudStart2;
	public float RandomCloudStart3;
	public float RandomCloudStart4;
	public float RandomCloudStart5;
	public float RandomCloudEnd1;
	public float RandomCloudEnd2;
	public float RandomCloudEnd3;
	public float RandomCloudEnd4;
	public float RandomCloudEnd5;
	public float RandomCloudSpeed1;
	public float RandomCloudSpeed2;
	public float RandomCloudSpeed3;
	public float RandomCloudSpeed4;
	public float RandomCloudSpeed5;
	public float RandomCloudPositionY1;
	public float RandomCloudPositionY2;
	public float RandomCloudPositionY3;
	public float RandomCloudPositionY4;
	public float RandomCloudPositionY5;

	// Use this for initialization
	void Start () {
		Invoke ("MakeCloud1", 0);
		Invoke ("MakeCloud2", 1);
		Invoke ("MakeCloud3", 2.5f);
		Invoke ("MakeCloud4", 4);
		Invoke ("MakeCloud5", 6);
	}

	void MakeCloud1 () {
		RandomCloud1 = Random.Range(0, 2);
		CloudRenderer1.sprite = ListCloud1[RandomCloud1];
		RandomCloudStart1 = Random.Range (-13f, 13f);
		if (RandomCloudStart1 > 10) {
			CloudStart1 = RandomCloudStart1 + 5;
			RandomCloudEnd1 = -13;
		} else if (RandomCloudStart1 < -10) {
			CloudStart1 = RandomCloudStart1 - 5;
			RandomCloudEnd1 = 13;
		}
		RandomCloudPositionY1 = Random.Range(0, 5);
		Cloud1.transform.position = new Vector3 (CloudStart1, RandomCloudPositionY1, 0);
		RandomCloudSpeed1 = Random.Range(2, 7);
		LeanTween.moveLocalX (Cloud1, RandomCloudEnd1, RandomCloudSpeed1).setOnComplete (OnCloudOut1);
	}

	void OnCloudOut1 () {
		Vector3 Cloud1 = gameObject.transform.position;
		Invoke ("MakeCloud1", 0);
	}

	void MakeCloud2 () {
		RandomCloud2 = Random.Range(0, 2);
		CloudRenderer2.sprite = ListCloud2[RandomCloud2];
		RandomCloudStart2 = Random.Range (-13f, 13f);
		if (RandomCloudStart2 > 10) {
			CloudStart2 = RandomCloudStart2 + 5;
			RandomCloudEnd2 = -13;
		} else if (RandomCloudStart2 < -10) {
			CloudStart2 = RandomCloudStart2 - 5;
			RandomCloudEnd2 = 13;
		}
		RandomCloudPositionY2 = Random.Range(0, 5);
		Cloud2.transform.position = new Vector3 (CloudStart2, RandomCloudPositionY2, 0);
		RandomCloudSpeed2 = Random.Range(2, 7);
		LeanTween.moveLocalX (Cloud2, RandomCloudEnd2, RandomCloudSpeed2).setOnComplete (OnCloudOut2);
	}

	void OnCloudOut2 () {
		Vector3 Cloud2 = gameObject.transform.position;
		Invoke ("MakeCloud2", 0);
	}

	void MakeCloud3 () {
		RandomCloud3 = Random.Range(0, 2);
		CloudRenderer3.sprite = ListCloud3[RandomCloud3];
		RandomCloudStart3 = Random.Range (-13f, 13f);
		if (RandomCloudStart3 > 10) {
			CloudStart3 = RandomCloudStart3 + 5;
			RandomCloudEnd3 = -13;
		} else if (RandomCloudStart3 < -10) {
			CloudStart3 = RandomCloudStart3 - 5;
			RandomCloudEnd3 = 13;
		}
		RandomCloudPositionY3 = Random.Range(0, 5);
		Cloud3.transform.position = new Vector3 (CloudStart3, RandomCloudPositionY3, 0);
		RandomCloudSpeed3 = Random.Range(2, 7);
		LeanTween.moveLocalX (Cloud3, RandomCloudEnd3, RandomCloudSpeed3).setOnComplete (OnCloudOut3);
	}

	void OnCloudOut3 () {
		Vector3 Cloud3 = gameObject.transform.position;
		Invoke ("MakeCloud3", 0);
	}

	void MakeCloud4 () {
		RandomCloud4 = Random.Range(0, 2);
		CloudRenderer4.sprite = ListCloud4[RandomCloud4];
		RandomCloudStart4 = Random.Range (-13f, 13f);
		if (RandomCloudStart4 > 10) {
			CloudStart4 = RandomCloudStart4 + 5;
			RandomCloudEnd4 = -13;
		} else if (RandomCloudStart4 < -10) {
			CloudStart4 = RandomCloudStart4 - 5;
			RandomCloudEnd4 = 13;
		}
		RandomCloudPositionY4 = Random.Range(0, 5);
		Cloud4.transform.position = new Vector3 (CloudStart4, RandomCloudPositionY4, 0);
		RandomCloudSpeed4 = Random.Range(2, 7);
		LeanTween.moveLocalX (Cloud4, RandomCloudEnd4, RandomCloudSpeed4).setOnComplete (OnCloudOut4);
	}

	void OnCloudOut4 () {
		Vector3 Cloud4 = gameObject.transform.position;
		Invoke ("MakeCloud4", 0);
	}

	void MakeCloud5 () {
		RandomCloud5 = Random.Range(0, 2);
		CloudRenderer5.sprite = ListCloud5[RandomCloud5];
		RandomCloudStart5 = Random.Range (-13f, 13f);
		if (RandomCloudStart5 > 10) {
			CloudStart5 = RandomCloudStart5 + 5;
			RandomCloudEnd5 = -13;
		} else if (RandomCloudStart5 < -10) {
			CloudStart5 = RandomCloudStart5 - 5;
			RandomCloudEnd5 = 13;
		}
		RandomCloudPositionY5 = Random.Range(0, 5);
		Cloud5.transform.position = new Vector3 (CloudStart5, RandomCloudPositionY5, 0);
		RandomCloudSpeed5 = Random.Range(2, 7);
		LeanTween.moveLocalX (Cloud5, RandomCloudEnd5, RandomCloudSpeed5).setOnComplete (OnCloudOut5);
	}

	void OnCloudOut5 () {
		Vector3 Cloud5 = gameObject.transform.position;
		Invoke ("MakeCloud5", 0);
	}
}
