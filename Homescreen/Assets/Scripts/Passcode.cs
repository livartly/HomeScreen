using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Passcode : MonoBehaviour {

    public string passcode;
    public GameObject display;

    private TextMeshProUGUI go;
    private const int PASSCODE_LENGTH = 4;

    // Use this for initialization
    void Start () {
        passcode = "";
        go = display.GetComponent<TextMeshProUGUI>();
    }
	
	// Update is called once per frame
	void Update () {

        if (passcode.Length >= PASSCODE_LENGTH)
        {
            //Check passcode
            CheckPasscode();
        }

        //Update display to show passcode
        go.text = passcode;
	}

    //Checks entered passcode against the randomly generated passcode
    void CheckPasscode()
    {

        //Reset the passcode
        passcode = "";
    }
}
