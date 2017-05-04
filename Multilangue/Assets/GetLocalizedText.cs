using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetLocalizedText : MonoBehaviour {

	Text m_textfield;
	Localization m_localizationScript;
	// Use this for initialization
	void Start () {
		m_localizationScript = GameObject.Find("Actions").GetComponent<Localization>();
		m_textfield = gameObject.GetComponent<Text>();
		m_textfield.text = m_localizationScript.GetString(m_textfield.text);
	}
}
