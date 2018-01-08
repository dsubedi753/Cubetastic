using UnityEngine;

public class PCollision : MonoBehaviour {
    
    void OnCollisionEnter(Collision info)
    {
        if (info.collider.tag=="Obstacle")
        {
            FindObjectOfType<GM>().EndGame();
        }
    }
}
