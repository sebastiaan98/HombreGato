using UnityEngine;
using System.Collections;

public class BaloonMovement : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed = 10f;
    [SerializeField]
    private Rigidbody rb;
    void Start()
    {
        
    }

    void Update()
    {



        Vector3 movement = new Vector3(0f, 4F, 0f);

        rb.velocity = movement * movementSpeed;
    }   
}
    
