using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");

        float verticalMovement = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalMovement, 0, verticalMovement);

        transform.Translate(direction * Time.deltaTime * speed);
    }
}
