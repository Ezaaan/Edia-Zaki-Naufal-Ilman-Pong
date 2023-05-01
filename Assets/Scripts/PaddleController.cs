using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public KeyCode upKey;
    public KeyCode downKey;
    public int speed;
    private int defaultSpeed;
    private float PUExtensionTimer;
    private float PUSpeedUpTimer;
    private bool PUExtensionState;
    private bool PUSpeedUpState;
    private float PUExtensionInterval;
    private float PUSpeedUpInterval;
    private Vector3 defaultLength;

    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        body= GetComponent<Rigidbody2D>();
        defaultSpeed = speed;
        PUSpeedUpState = false;
        PUExtensionState = false;
        defaultLength = new Vector3(0, body.transform.localScale.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject(GetInput());
        if (PUExtensionState)
        {
            PUExtensionTimer += Time.deltaTime;
        }

        if (PUSpeedUpState)
        {
            PUSpeedUpTimer += Time.deltaTime;
        }

        if (PUExtensionState && PUExtensionTimer >= PUExtensionInterval)
        {
            PUExtensionState = false;
            body.transform.localScale -= defaultLength;
            Debug.Log("Extension Paddle EXPIRE");
        }

        if (PUSpeedUpState && PUSpeedUpTimer >= PUSpeedUpInterval)
        {
            PUSpeedUpState = false;
            speed = defaultSpeed;
            Debug.Log("Speed Paddle EXPIRE");
        }
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        Debug.Log("TEST: " + movement);
        body.velocity= movement;
    }

    public void ActivatePUExtendPaddle(float interval)
    {   
        if (!PUExtensionState)
        {
            PUExtensionState = true;
            body.transform.localScale += defaultLength;
            PUExtensionTimer = 0;
            PUExtensionInterval = interval;
        }
        
    }

    public void ActivatePUSpeedPaddle(float interval)
    {
        if (!PUSpeedUpState)
        {
            PUSpeedUpState = true;
            speed += defaultSpeed;
            PUSpeedUpTimer = 0;
            PUSpeedUpInterval = interval;
        }

    }
}
