using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        //legacy movement system
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //using legacy inputs, move
        Vector3 moveDirection = new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;
        transform.Translate(moveDirection);
    }
}
