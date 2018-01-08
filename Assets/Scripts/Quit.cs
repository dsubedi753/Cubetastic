using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public void Finish()
    {
        Debug.Log("Ended");
        Application.Quit();
    }
    public void starting()
    {
        Debug.Log("Starting");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}