using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public AudioClip clip;
    public AudioClip clip2;
    public GameObject player;
    private GameObject[] pauseObjects;
    private bool touched;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("PauseObject");
        foreach (GameObject p in pauseObjects)
        {
            p.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player.activeInHierarchy)
        {
            if (Input.touchCount == 0)
            {
                touched = false;
            }
            else if (Input.touchCount == 1)
            {
                if (touched)
                {
                    return;
                }
                else
                {
                    touched = true;
                    if (Time.timeScale == 1)
                    {
                        AudioSource.PlayClipAtPoint(clip2, new Vector3(0, 0, -8));
                        Time.timeScale = 0;
                        foreach (GameObject p in pauseObjects)
                        {
                            p.SetActive(true);
                        }
                    }
                    else
                    {
                        Time.timeScale = 1;
                        AudioSource.PlayClipAtPoint(clip, new Vector3(0, 0, -8));
                        foreach (GameObject p in pauseObjects)
                        {
                            p.SetActive(false);
                        }
                    }
                }
            }
        }
    }
}
