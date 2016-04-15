using UnityEngine;
using System.Collections;

public class MoveBullet : MonoBehaviour {

	public int moveSpeed = 230;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * Time.deltaTime * moveSpeed);
		Destroy (gameObject, 2);
	}

	void OnTriggerEnter2D(Collider2D coll) {
		Debug.Log (coll.gameObject.name);
		//if (coll.gameObject.name == "PlatformWhiteSprite 1") {
		//	Destroy (gameObject);
		//}
	}
}
