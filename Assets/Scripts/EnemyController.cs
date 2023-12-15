using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyController : MonoBehaviour
{
    public float speed = 10;
    public float xRange = 10;
    public static float moveSpeed = 1;
    public Vector3 enemyDirection = Vector3.forward;
    public float changeDelay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ChangeDirection", changeDelay, changeDelay);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        transform.Translate(enemyDirection * moveSpeed * Time.deltaTime * speed);
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime * speed);
    }

    public void ChangeDirection()
    {
        speed *= -1;
    }
}
