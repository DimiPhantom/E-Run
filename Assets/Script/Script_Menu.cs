using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_Menu : MonoBehaviour {

	public Button StoryButton;
	public Button InfinityButton;
	public Button CoinRushButton;
	public Button OptionsButton;
	public Button StoreButton;
	// Use this for initialization
	void Start () {
		StoryButton.onClick.AddListener (StoryButtonClicked);
		InfinityButton.onClick.AddListener (InfinityButtonClicked);
		CoinRushButton.onClick.AddListener (CoinRushButtonClicked);
		OptionsButton.onClick.AddListener (OptionsButtonClicked);
		StoreButton.onClick.AddListener (StoreButtonClicked);
	}
	void StoryButtonClicked()
	{
	}
	void InfinityButtonClicked()
	{
		Application.LoadLevel ("Game_Infinity");
	}
	void CoinRushButtonClicked()
	{
	}
	void OptionsButtonClicked()
	{
	}
	void StoreButtonClicked()
	{
	}

}
