using UnityEngine;

public class End : MonoBehaviour 
{
    void OnCollisionEnter(Collision info)
    {

        if (info.collider.tag == "Player")
        {
            FindObjectOfType<GM>().Win();
        }
    }
 
}
