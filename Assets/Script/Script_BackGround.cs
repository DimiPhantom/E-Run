using UnityEngine;
using System.Collections;

public class Script_BackGround : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		transform.Translate (-70 * Time.deltaTime, 0, 0);
		if (transform.localPosition.x < -263) {
			transform.Translate (526, 0, 0);
		}
	}
}
