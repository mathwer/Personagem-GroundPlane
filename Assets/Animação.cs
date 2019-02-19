using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animação : MonoBehaviour
{
    public FloatingJoystick joystick;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveVector = (Vector3.right * joystick.Horizontal + Vector3.forward * joystick.Vertical);

        if (moveVector != Vector3.zero) anim.SetTrigger("Andar");

        else anim.SetTrigger("Parar");
    }
    public void BotaoAceno()
    {
        anim.SetTrigger("Acenar");
    }

    public void BotaoDanca()
    {
        anim.SetTrigger("Danca");
    }

    public void BotaoPular()
    {
        anim.SetTrigger("Jump");
    }
}
