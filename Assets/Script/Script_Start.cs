using UnityEngine;
using System.Collections;

public class Script_Start : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (Input.touchCount > 0) {
			Application.LoadLevel ("Menu");
		}
	}
}
