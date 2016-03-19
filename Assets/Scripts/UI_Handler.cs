using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI_Handler : MonoBehaviour {

	public GameObject Main_menu_panel;
	public GameObject Components_menu_panel;


	// Use this for initialization
	void Start () 
	{
		//disable Components Menu 
		Components_menu_panel.GetComponent<CanvasGroup>().alpha =0;
		Components_menu_panel.GetComponent<CanvasGroup>().interactable =true;
	
		//enable Main Menu
		Main_menu_panel.GetComponent<CanvasGroup>().alpha =1;
		Main_menu_panel.GetComponent<CanvasGroup>().interactable =true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void play_button_handler()
	{
		Debug.Log ("Play Button Pressed");

	}


	public void Add_Component_button_handler()
	{
		Debug.Log ("Add component button pressed");
		// disable main menu 
		//Main_menu_panel.GetComponent<CanvasGroup>().alpha=0;
		//Main_menu_panel.GetComponent<CanvasGroup> ().interactable = false;



		// enable components meny
	//	Components_menu_panel.GetComponent<CanvasGroup>().alpha = 1;
	//	Components_menu_panel.GetComponent<CanvasGroup> ().interactable = true;








	}

	public void Settings_button_handler()
	{
		Debug.Log ("Settings button pressed");

	}









}
