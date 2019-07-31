using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad * 100 > 1000) speed = 2.6f;
        if (Time.timeSinceLevelLoad * 100 > 1500) speed = 2.7f;
        if (Time.timeSinceLevelLoad * 100 > 2000) speed = 2.8f;
        if (Time.timeSinceLevelLoad * 100 > 2500) speed = 2.9f;
        if (Time.timeSinceLevelLoad * 100 > 3000) speed = 3.0f;
        if (Time.timeSinceLevelLoad * 100 > 3500) speed = 3.2f;
        if (Time.timeSinceLevelLoad * 100 > 4000) speed = 3.4f;
        if (Time.timeSinceLevelLoad * 100 > 4500) speed = 3.6f;
        if (Time.timeSinceLevelLoad * 100 > 5000) speed = 3.8f;
        if (Time.timeSinceLevelLoad * 100 > 5500) speed = 4.0f;
        if (Time.timeSinceLevelLoad * 100 > 6000) speed = 4.2f;
        if (Time.timeSinceLevelLoad * 100 > 6500) speed = 4.4f;
        if (Time.timeSinceLevelLoad * 100 > 7000) speed = 4.6f;
        if (Time.timeSinceLevelLoad * 100 > 7500) speed = 4.8f;
        if (Time.timeSinceLevelLoad * 100 > 8000) speed = 5.0f;
        if (Time.timeSinceLevelLoad * 100 > 8500) speed = 5.2f;
        if (Time.timeSinceLevelLoad * 100 > 9000) speed = 5.4f;
        if (Time.timeSinceLevelLoad * 100 > 9500) speed = 5.6f;
        if (Time.timeSinceLevelLoad * 100 > 10000) speed = 5.8f;
        if (Time.timeSinceLevelLoad * 100 > 10500) speed = 6.0f;
        if (Time.timeSinceLevelLoad * 100 > 11000) speed = 6.5f;
        if (Time.timeSinceLevelLoad * 100 > 11500) speed = 7.0f;
        if (Time.timeSinceLevelLoad * 100 > 12000) speed = 7.5f;
        if (Time.timeSinceLevelLoad * 100 > 12500) speed = 8.0f;
        float y = -1 * speed * Time.deltaTime;
        transform.position += new Vector3(0, y, 0);

        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }
}
