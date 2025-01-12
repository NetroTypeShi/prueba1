using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MovementFwae : MonoBehaviour    
{
    [SerializeField] float speed = 0f;
    [SerializeField] float distanceLimiter = 5f;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
      direction = Vector3.right;
    gameObject.transform.position = new Vector3(-distanceLimiter,0,0);
    }

    // Update is called once per frame
    void Update()
    {

     gameObject.transform.position += direction * Time.deltaTime * speed;
        if (gameObject.transform.position.x > distanceLimiter)
        {
            gameObject.transform.position = new Vector3(-distanceLimiter, 0, 0);
        }
        if(gameObject.transform.position.x < -distanceLimiter)
        {
            gameObject.transform.position = new Vector3(distanceLimiter, 0, 0);
        }
    }
}
