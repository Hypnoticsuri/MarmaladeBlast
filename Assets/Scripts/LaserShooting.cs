using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShooting : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float speed = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Launce a Projectile From Player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
