using UnityEngine;
using UnityEngine.SceneManagement;
public class GM : MonoBehaviour {
    public GameObject Msg;
    private bool ended = false;
	public void EndGame() //loose
    {
        
        if (ended == false)
        {
            FindObjectOfType<First>().enabled = false;
            ended = true;
            Debug.Log("Game Over");
            FindObjectOfType<Score>().enabled = false;
            Invoke("Restart",2f);
        }

    }
    
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Win()
    {
        if (ended==false)
        {
            Debug.Log("Completed");
            FindObjectOfType<First>().stop();
            FindObjectOfType<First>().enabled = false;
            Invoke("Show", 0.5f);
        }
    }   
    void Show() 
    {
        Msg.SetActive(true);
    }

}
