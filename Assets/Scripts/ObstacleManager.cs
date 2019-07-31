using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject obstacle1;
    public GameObject obstacle3;
    public GameObject obstacle4;
    public GameObject obstacle5;
    private int obstacleCount = 0;
    private GameObject[] obstacles;
    private float[] xCoor;

    // Start is called before the first frame update
    void Start()
    {
        for (float y = 2; y <= 13; y += 3)
        {
            Camera camera = Camera.main;
            float halfWidth = camera.aspect * camera.orthographicSize;
            float inc;
            inc = Mathf.Round((halfWidth + 1) / 2.5f);
            xCoor = new float[]{ 0, 0 + inc, 0 - inc, 0 + (inc * 2), 0 - (inc * 2) };
            obstacles = new GameObject[]{ obstacle1, obstacle3, obstacle4, obstacle5 };
            List<float> spots = new List<float>(xCoor);
            for (int n = 3; n > 0; n--)
            {
                int i = Random.Range(0, obstacles.Length);
                int x = Random.Range(0, spots.Count);
                Instantiate(obstacles[i], new Vector3(spots[x], y, 1), Quaternion.identity, transform);
                spots.RemoveAt(x);
                obstacleCount++;
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (obstacleCount - transform.childCount > 0)
        {
            List<float> spots = new List<float>(xCoor);
            for (int n = 3; n > 0; n--)
            {
                int i = Random.Range(0, obstacles.Length);
                int x = Random.Range(0, spots.Count);
                Instantiate(obstacles[i], new Vector3(spots[x], 7, 1), Quaternion.identity, transform);
                spots.RemoveAt(x);
            }
        }
    }
}
