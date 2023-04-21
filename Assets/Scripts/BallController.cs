using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetPosition;
    private Rigidbody2D body;

    public void ActivatePUSpeedUp(float magnitude)
    {
        body.velocity *= magnitude;
    }

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
    }


    // Start is called before the first frame update
    void Start()
    {
        body= GetComponent<Rigidbody2D>();
        body.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
