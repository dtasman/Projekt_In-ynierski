using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

	public Sprite layer_blue, layer_red;
	public GameObject m_on, m_off;


	void Start() {
	
	 if (gameObject.name == "Music") {
		
			if (PlayerPrefs.GetString("Music") == "no") {
				m_on.SetActive(false);
				m_off.SetActive(true);
			}
			else
			{
				m_on.SetActive(true);
				m_off.SetActive(false);
			}
		}
	}

	void OnMouseDown () {
		GetComponent <SpriteRenderer> ().sprite = layer_red;
	}

	void OnMouseUp () {
		GetComponent <SpriteRenderer> ().sprite = layer_blue;
	}

	void OnMouseUpAsButton () {
		if (PlayerPrefs.GetString("Music") != "no")
			GameObject.Find("Click Audio").GetComponent<AudioSource>().Play();
		switch (gameObject.name) {
		case "Play":
			Application.LoadLevel ("play");
			break;
		case "Share_Ratinf":
			Application.OpenURL ("http://google.com");
			break;
		case "Replay":
		        Application.LoadLevel ("Play");
			break;
		case "Home":
		        Application.LoadLevel ("SampleScene 1");
			break;
			case "How to":
				Application.LoadLevel("how To");
				break;
			case "Close":
				Application.LoadLevel("SampleScene 1");
				break;
			case "Music":
				if (PlayerPrefs.GetString("Music") != "no") {
					PlayerPrefs.SetString("Music", "no");
					m_on.SetActive(false);
					m_off.SetActive(true);
				} else {
					PlayerPrefs.SetString("Music", "yes");
					m_on.SetActive(true);
					m_off.SetActive(false);
				}
				break;
		}
	}
}
