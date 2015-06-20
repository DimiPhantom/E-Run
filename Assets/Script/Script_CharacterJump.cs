using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_CharacterJump : MonoBehaviour {

	public Button JumpButton;
	void Start()
	{
		JumpButton.onClick.AddListener (delegate{StartCoroutine(CharacterJump());});
	}
	IEnumerator CharacterJump()
	{
		if (transform.localPosition.y == -25) {
			for (int i=0; i<20; i++) {
				transform.Translate (0, 3, 0);
				yield return new WaitForSeconds (0.01f);
			}
			for (int i=0; i<20; i++) {
				transform.Translate (0, -3, 0);
				yield return new WaitForSeconds (0.01f);
			}
		}
	}
}
