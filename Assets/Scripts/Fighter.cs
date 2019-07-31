using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Fighter : MonoBehaviour
{
    public float speed = 5.0f;
    public Text scoreText;
    public Text highscoreText;
    public GameObject explosion;
    public GameObject retryButton;
    public GameObject quitButton;
    public AudioClip clip;
    private EventSystem eventSystem;
    private float highscore;

    // Start is called before the first frame update
    void Start()
    {
        eventSystem = EventSystem.current;
        highscore = PlayerPrefs.GetFloat("highscore", 0f);
        highscoreText.text = "Highscore: " + highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Camera camera = Camera.main;
        float halfWidth = camera.aspect * camera.orthographicSize - 0.5f;
        float score = Mathf.Round(Time.timeSinceLevelLoad * 6);
        if (score > highscore)
        {
            PlayerPrefs.SetFloat("highscore", score);
            highscoreText.text = "Highscore: " + score.ToString();
        }
        scoreText.text = "Score: " + score.ToString();
        if (transform.position.x > halfWidth && Input.acceleration.x > 0)
        {
            return;
        }
        else if (transform.position.x < -halfWidth && Input.acceleration.x < 0)
        {
            return;
        }
        else
        {
            float x = Input.acceleration.x * speed * Time.deltaTime;
            transform.position += new Vector3(x, 0, 0);
        }
    }

    void OnTriggerEnter2D()
    {
        Instantiate(explosion, transform.position, transform.rotation);
        AudioSource.PlayClipAtPoint(clip, new Vector3(0, 0, -10));
        Destroy(gameObject);
        retryButton.SetActive(true);
        quitButton.SetActive(true);
        eventSystem.SetSelectedGameObject(retryButton);
    }
}
