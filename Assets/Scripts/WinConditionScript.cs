using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinConditionScript : MonoBehaviour {
	
	Text text;

	private void Awake()
	{
		text = GameObject.Find ("Text").GetComponent<Text>();
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.attachedRigidbody.gameObject.name == "CharacterRobotBoy") {
			text.text = "YOU WIN";
			Time.timeScale = 0;
		}
	}
}
