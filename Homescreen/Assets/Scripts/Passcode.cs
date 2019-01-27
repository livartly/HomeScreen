﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Passcode : MonoBehaviour {

    public string passcode;
    public GameObject display;

    private TextMeshProUGUI codeDisplay;
    private const int PASSCODE_LENGTH = 4;
    private string validPasscode;
    private float timeLeft = 70;
    public GameObject timeDisplay;
    private TextMeshProUGUI timer;
    public GameObject smallTimeDisplay;
    private TextMeshProUGUI smallTimer;
    public GameObject content;

    public GameObject Notification;
    public GameObject NotificationFromMOM;
    public GameObject NotificationFromInstagram;

    private int Attempts = 0;



    private bool isChecking;
    private bool isUnlocked;

    // Use this for initialization
    void Start () {
        passcode = "";
        codeDisplay = display.GetComponent<TextMeshProUGUI>();
        timer = timeDisplay.GetComponent<TextMeshProUGUI>();
        smallTimer = smallTimeDisplay.GetComponent<TextMeshProUGUI>();

        isChecking = false;

        //Generate a random passcode
        validPasscode =  Random.Range(0, 9999).ToString();
    }
	
	// Update is called once per frame
	void Update () {
        

        if (timeLeft > 0f)
        {
            if (isUnlocked == false)
            {
                timeLeft -= Time.deltaTime;
            }

            if (timeLeft < 0)
            {
                timeLeft = 0;

            }


            //Debug.Log((int)timeLeft);
            int timeLeftInt = (int)timeLeft;
            int seconds = timeLeftInt % 60;
            int minutes = (int)Mathf.Floor(timeLeft / 60);
            string textString = "";
            if (minutes < 10)
                textString += "0";
            textString += minutes.ToString();
            textString += ":";
            if (seconds < 10)
                textString += "0";
            textString += seconds.ToString();
            timer.text = textString;
            smallTimer.text = textString;
            //timer.text = timeLeftInt.ToString();
        }

        if ((passcode.Length >= PASSCODE_LENGTH) && (!isChecking))
        {
            //Check passcode
            isChecking = true;
            CheckPasscode();
        }
        //Update display to show passcode
        codeDisplay.text = passcode;
	}

    //Checks entered passcode against the randomly generated passcode
    void CheckPasscode()
    {
        //Tick attempts up
        Attempts++;

        string hint ="";
        if (passcode == validPasscode)
        {
            Unlock();
        }
        else
        {
            //Check if any numbers match
            for (int i = 0; i < 4; i += 1)
            {

                if (validPasscode.Contains(passcode.Substring(i, 1)))
                {

                    //If valid passcode contains first number
                    if (passcode[i] == validPasscode[i])
                    {


                        /// right position
                        hint += " XD ";
                    }
                    else
                    {


                        /// right number wrong position

                        hint += " ;) ";
                    }
                }
                else
                {


                    /// wrong number wrong position
                    /// 
                    hint += " :( ";
                }
            }
            //Instantiate Notification
            Vector3 offset = new Vector3(50f, -60f * Attempts, 0f);
            Vector3 nextPos = offset + content.transform.position;
            if (Random.Range(0, 9) < 7)
            {
                GameObject go = Instantiate(Notification, nextPos, Quaternion.identity, content.transform);
                go.transform.GetComponentInChildren<TextMeshProUGUI>().text = "You entered: " + passcode + "\nHere is your hint: " + hint;
            }
            else
            {
                GameObject go = Instantiate(NotificationFromInstagram, nextPos, Quaternion.identity, content.transform);
                go.transform.GetComponentInChildren<TextMeshProUGUI>().text = "You entered: " + passcode + "\nHere is your hint: " + hint;
            }
            Debug.Log(validPasscode);
        }

        //Wait coroutine 
        StartCoroutine(Wait());
    }

    //Wait 
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(.5f);
        ClearPasscode();
        isChecking = false;
    }

    //Reset the passcode
    void ClearPasscode()
    {
        passcode = "";
    }

    void Unlock()
    {
        //Stop timer
        isUnlocked = true;

        GetComponent<ButtonClicks>().OnButtonClick_OpenHomeScreen();
        Vector3 offset = new Vector3(50f, -60f * Attempts, 0f);
        Vector3 nextPos = offset + content.transform.position;
        GameObject go = Instantiate(NotificationFromMOM, nextPos, Quaternion.identity, content.transform);
        go.transform.GetComponentInChildren<TextMeshProUGUI>().text = "Mom: I'm proud of you <3";
        Debug.Log("You win");
    }
}