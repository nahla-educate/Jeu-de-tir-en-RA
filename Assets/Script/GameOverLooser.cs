using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverLooser : MonoBehaviour
{
    public GameObject GameOver;
   
    void OnCollisionEnter(Collision collision)
    {   GameOver.SetActive(true);
        //SceneManager.LoadScene("Menu"); 
    }
}

