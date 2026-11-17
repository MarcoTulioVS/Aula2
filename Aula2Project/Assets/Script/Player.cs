using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float rotateSpeed;

    private float movementStraight;
    private float rotateMovement;
    void Start()
    {
        
    }

    
    void Update()
    {
        Movement();
        Rotate();
    }

    public void Movement()
    {
        movementStraight = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(0,0,movementStraight * speed * Time.deltaTime));

    }

    public void Rotate()
    {
        rotateMovement = Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0,rotateMovement * rotateSpeed * Time.deltaTime));
    }
}
