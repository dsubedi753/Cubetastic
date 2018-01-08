using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level_No : MonoBehaviour {
    public Text lvln;
	// Use this for initialization
	void Update () {
        lvln.text = "Level " +(SceneManager.GetActiveScene().buildIndex).ToString();
	}
}
