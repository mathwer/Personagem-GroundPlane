using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStick : MonoBehaviour
{
    public float moveSpeed = 0.5f;
    public FloatingJoystick joystick;
    private Vector3 direction;
    private float xMin, xMax, yMin, yMax;
    Animator anim;
    // Update is called once per frame

    void Update()
    {
        Vector3 moveVector = (Vector3.right * joystick.Horizontal + Vector3.forward * joystick.Vertical);

        while (moveVector != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveVector);
            transform.Translate(moveVector * moveSpeed * Time.deltaTime, Space.World);
            anim.SetTrigger("Andar");

        }

        if (moveVector == Vector3.zero)
        {
            anim.SetTrigger("Parar");
        }



    }
}