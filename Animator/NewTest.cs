using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum States 
{
    IDLE = -357476191,
    WALK= -1157326879
}
public class NewTest : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        Debug.Log(Animator.StringToHash("IDLE"));
        Debug.Log(Animator.StringToHash("WALK"));

        animator.SetTrigger((int)States.IDLE);
    }
}
