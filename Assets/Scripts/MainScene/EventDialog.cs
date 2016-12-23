﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventDialog : MonoBehaviour {
	public Text dialog;
	int someTime;
	string somtetag;
	protected Button yesbtn;
	protected Button nobtn1;

	void Awake()
	{
		yesbtn = this.gameObject.GetComponentsInChildren<Button>()[1];
		yesbtn.onClick.AddListener(TaskOnClick);
		nobtn1 = this.gameObject.GetComponentsInChildren<Button>()[0];
		nobtn1.onClick.AddListener(TaskOnClick1);
		//dialog = this.gameObject.GetComponentsInChildren<Text>()[0];
		gameObject.SetActive (false);
		PlayerEvents.PlayerEvent += DisplayDialog;
		Debug.Log (dialog);

	}

	void OnDestroy()
	{
		PlayerEvents.PlayerEvent -= DisplayDialog;
	}

	void DisplayDialog(string tag, int Time)
	{
		PlayerMovement.canmove = false;
		somtetag = tag;
		someTime = Time;

		switch (tag) {
		case "whiteboard":
			dialog.text = "Is it time for ALGORITHMS?!?!";
			break;
		case "platform":
			dialog.text = "Platform time?";
			break;
		case "project":
			dialog.text = "How about working on that project?";
			break;
		case "NapTimewifSal":
			dialog.text = "Do you want to take a nap?";
			break;
		default:
			break;
		

		}
		gameObject.SetActive (true);
	}



	public void TaskOnClick(){
			

		PlayerEvents.doSomeStuff (somtetag, someTime);
		gameObject.SetActive (false);
		PlayerMovement.canmove = true;

	}

	public void TaskOnClick1(){
		gameObject.SetActive (false);
		PlayerMovement.canmove = true;
	}


}

