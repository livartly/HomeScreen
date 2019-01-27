using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClicks : MonoBehaviour {

    public GameObject lockScreen;
    public GameObject homeScreen;
    private Passcode passcode;

    void Start()
    {
        passcode = GetComponent<Passcode>();
    }


    //Adds 0 to the passcode
    public void OnButtonClick_0 ()
    {
        if ((passcode.passcode.Length < Passcode.PASSCODE_LENGTH))
            passcode.passcode += "0";
    }

    //Adds 1 to the passcode
    public void OnButtonClick_1()
    {
        if ((passcode.passcode.Length < Passcode.PASSCODE_LENGTH))
            passcode.passcode += "1";
    }

    //Adds 2 to the passcode
    public void OnButtonClick_2()
    {
        if ((passcode.passcode.Length < Passcode.PASSCODE_LENGTH))
            passcode.passcode += "2";
    }

    //Adds 3 to the passcode
    public void OnButtonClick_3()
    {
        if ((passcode.passcode.Length < Passcode.PASSCODE_LENGTH))
            passcode.passcode += "3";
    }

    //Adds 4 to the passcode
    public void OnButtonClick_4()
    {
        if ((passcode.passcode.Length < Passcode.PASSCODE_LENGTH))
            passcode.passcode += "4";
    }

    //Adds 5 to the passcode
    public void OnButtonClick_5()
    {
        if ((passcode.passcode.Length < Passcode.PASSCODE_LENGTH))
            passcode.passcode += "5";
    }

    //Adds 6 to the passcode
    public void OnButtonClick_6()
    {
        if ((passcode.passcode.Length < Passcode.PASSCODE_LENGTH))
            passcode.passcode += "6";
    }

    //Adds 7 to the passcode
    public void OnButtonClick_7()
    {
        if ((passcode.passcode.Length < Passcode.PASSCODE_LENGTH))
            passcode.passcode += "7";
    }

    //Adds 8 to the passcode
    public void OnButtonClick_8()
    {
        if ((passcode.passcode.Length < Passcode.PASSCODE_LENGTH))
            passcode.passcode += "8";
    }

    //Adds 9 to the passcode
    public void OnButtonClick_9()
    {
        if ((passcode.passcode.Length < Passcode.PASSCODE_LENGTH))
            passcode.passcode += "9";
    }

    //Opens the LockScreen
    public void OnButtonClick_OpenLockScreen()
    {
        //Enable Lockscreen
        lockScreen.SetActive(true);
        //Disable Homescreen
        homeScreen.SetActive(false);
    }

    //Opens the LockScreen
    public void OnButtonClick_OpenHomeScreen()
    {
        //Enable Lockscreen
        homeScreen.SetActive(true);
        //Disable Homescreen
        lockScreen.SetActive(false);
    }
}
