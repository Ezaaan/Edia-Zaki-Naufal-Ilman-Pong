using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedUpController : MonoBehaviour
{
    public Collider2D ball;
    public float magnitude;
    public PowerUpManager manager;
    private float despawnTimer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            ball.GetComponent<BallController>().ActivatePUSpeedUp(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        despawnTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        despawnTimer += Time.deltaTime;
        //Debug.Log("Despawn timer: " + despawnTimer);
        if(despawnTimer >= manager.despawnInterval)
        {
            manager.RemovePowerUp(gameObject);
            despawnTimer -= manager.despawnInterval;
        }
        
    }
}
