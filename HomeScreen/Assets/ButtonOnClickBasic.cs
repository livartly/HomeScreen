using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOnClickBasic : MonoBehaviour {


    public GameObject unlockedImage;
    public Button unlockButton;
    // Use this for initialization
    void Start () {
        unlockButton.onClick.AddListener(Unlock);
	}
	
	// Update is called once per frame
	void Update () {
		
	}




    void Unlock()
    {
        Debug.Log("Phone unlocked");
        unlockedImage.SetActive(true);
    }
}
