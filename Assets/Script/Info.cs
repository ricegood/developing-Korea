﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Info : MonoBehaviour {
	string myText;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		myText = Character.getOrder() + "대\n" + Character.getName ();
		Util.setText (this.GetComponent<Text>(), myText);
	}


}
