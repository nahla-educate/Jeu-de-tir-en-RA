using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeadScript : MonoBehaviour
{
     ShootingTarget STarget;

    void Start()
    { StartCoroutine("LoadMenu"); }
    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Menu");

        int score = STarget.Monscore;
        if (score > PlayerPrefs.GetInt("score"))
        {
            PlayerPrefs.SetInt("score", score);
        }

    }
}
