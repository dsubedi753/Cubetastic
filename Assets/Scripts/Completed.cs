using UnityEngine;
using UnityEngine.SceneManagement;

public class Completed : MonoBehaviour 
{
    public void Nextlvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
	
}
