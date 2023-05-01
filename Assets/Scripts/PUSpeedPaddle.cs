using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedPaddle : MonoBehaviour
{

    public Collider2D ball;
    public int Duration;
    public PowerUpManager manager;
    private float despawnTimer;
    public Rigidbody2D leftPaddle;
    public Rigidbody2D rightPaddle;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            //Debug.Log("GET SPEED UP PADDLE");
            leftPaddle.GetComponent<PaddleController>().ActivatePUSpeedPaddle(Duration);
            rightPaddle.GetComponent<PaddleController>().ActivatePUSpeedPaddle(Duration);
            manager.RemovePowerUp(gameObject); ;
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
        if (despawnTimer >= manager.despawnInterval)
        {
            manager.RemovePowerUp(gameObject);
            despawnTimer -= manager.despawnInterval;
        }
    }
}
