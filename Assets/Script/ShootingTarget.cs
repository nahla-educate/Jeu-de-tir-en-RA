using UnityEngine;
using UnityEngine.UI;
public class ShootingTarget : MonoBehaviour
{
    public GameObject prefabExplosion;

    RaycastHit hit;

    public Text txtScore;
    private int score = 0;

    AudioSource MyAudioSource;
    public AudioClip ShootSound, ExplosionSound;

    public int Monscore
    {
        get { return score; }
        set { score = value; txtScore.text = "" + score; }
    }
    private void Start()
    {
        GameObject.Find("Best Score").GetComponent<Text>().text = "" +
        PlayerPrefs.GetInt("score").ToString();
        MyAudioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        Vector2 center = new Vector2(Screen.width / 2, Screen.height / 2);
        Ray ray = Camera.main.ScreenPointToRay(center);
        if (Input.GetButtonDown("Fire1"))
        {
            MyAudioSource.PlayOneShot(ShootSound); // lancer le bruitage de tir

            if (Physics.Raycast(ray, out hit, Mathf.Infinity)) //Renvoie V si le rayon croise un collider
            {   Destroy(hit.collider.transform.gameObject);
                 
                GameObject Go = Instantiate(prefabExplosion, hit.transform.position, Quaternion.identity);
                Destroy(Go, 5f);// Détruire l’ennemi
                MyAudioSource.PlayOneShot(ExplosionSound); // lancer le bruitage de l’explosion
            } 
        }
        Monscore++;
    }
}


