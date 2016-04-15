using UnityEngine;
using System.Collections;

public class CameraScriptPls : MonoBehaviour {

	public Transform objectToTrack;

	private void LateUpdate()
	{
		var pos = Camera.main.transform.position;
		Camera.main.transform.position = new Vector3(objectToTrack.position.x, objectToTrack.position.y, pos.z);  
	}
}
