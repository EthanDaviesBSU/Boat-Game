using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmarineMovement : MonoBehaviour
{
    private Rigidbody2D body;

    // public float velocity;
    public bool isMoving = false;

    public float moveSpeed = 1000f;
    private float moveHorizontal;
    private float moveVertical;

    private float test;
    private float currentPos;

    public float limitVelocity = 10f;

    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();

        // Debug.Log("Max Battery: " + ShipStats.maxBattery);
        // Debug.Log("Battery Decay: " + ShipStats.batteryDecay);
        // Debug.Log("Move Speed: " + ShipStats.moveSpeed);
        // Debug.Log("Limit Velocity: " + ShipStats.limitVelocity);
        // Debug.Log("Oxygen Decay: " + ShipStats.oxygenDecay);
        // Debug.Log("Oxygen Regen: " + ShipStats.oxygenRegen);
        // Debug.Log("Max Oxygen: " + ShipStats.maxOxygen);
        // Debug.Log("Money Multiplier: " + ShipStats.moneyMultiplier);
        // Debug.Log("Sub Health: " + ShipStats.subHealth);
        // Debug.Log("Spotlight Range: " + ShipStats.spotlightRange);
        // Debug.Log("Aura Range: " + ShipStats.auraRange);
        // Debug.Log("Total Money: " + ShipStats.totalMoney);
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        if (body.velocity.y != 0 || body.velocity.x != 0)
        {
            if(!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            audioSource.Stop();
        }
    }

    void FixedUpdate()
    {
        if (transform.position.y > 20)
        {
            transform.position = new Vector3(transform.position.x, 20.0f, transform.position.z);
        }

        body.velocity = new Vector2 (moveHorizontal*ShipStats.moveSpeed*Time.deltaTime, moveVertical*ShipStats.moveSpeed*Time.deltaTime);

       if (body.velocity.magnitude > ShipStats.limitVelocity)
       {
           body.velocity = Vector3.ClampMagnitude(body.velocity, ShipStats.limitVelocity);
       }
    }
}
