using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour {

public void RestartGame()
{
	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}

public void QuitGame()
{
	Application.Quit();
}

}
