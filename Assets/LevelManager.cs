using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	int currentIndex;

	public void LoadNextScene () { 
		currentIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(++currentIndex);
	}

	public void LoadPreviousScene () {
		currentIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene (--currentIndex);
	}

	public void Quit() {
		print ("Quitting Game");
		Application.Quit();
	}
}
