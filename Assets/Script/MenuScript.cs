using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{
    public void Play()
    { SceneManager.LoadScene("Jeu AR"); }
    public void Exit()
    { Application.Quit(); }
}
