using UnityEngine;

public class Follow : MonoBehaviour {
    public Transform plr;
    public Vector3 offset;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = plr.position+offset;   
        
	}
}
