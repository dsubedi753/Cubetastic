using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	// Use this for initialization
    public Transform pleya;
    public Text stext;
	void Update () {
    
        stext.text = (pleya.position.z-5).ToString("0");
	}
}
