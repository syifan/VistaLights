﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Window : MonoBehaviour {

	public GameObject ship;
	public GameObject window;
	public GameObject closed;
	public GameObject submited;

	/*
	 * input text to send
	 */
	public InputField priority;

	/*
	 *  Ship's information
	 */
	public Text ShipName;
	public Text ShipType;
	public Text CurrentPriority;



	public void setShip(GameObject Ship){
		this.ship = Ship;
	}
	
	void Start(){
		PresentInformation ();
		ShipName = GameObject.Find ("ShipName").GetComponent<Text> (); 
		CurrentPriority = GameObject.Find ("CurrentPriority").GetComponent<Text> ();
	}

	void Update(){
		closed.GetComponent<Button> ().onClick.AddListener (() => {
			closedwindow ();});
		submited.GetComponent<Button> ().onClick.AddListener (() => {
			submitedwindow ();});
	}


	public void closedwindow(){
		Destroy (window);
	}

	public void submitedwindow(){
		//textfield = priority.text;
		//GetComponent<ShipPropertyWindow>().hitObject.GetComponent<Ship>().priority = int.Parse(textfield);
		ship.GetComponent <Ship> ().setpriority (priority.text);
	}


	public void PresentInformation(){
		ShipName.text= ship.GetComponent<Ship>().Name;
		CurrentPriority.text = (ship.GetComponent<Ship> ().priority).ToString();
	}


}
