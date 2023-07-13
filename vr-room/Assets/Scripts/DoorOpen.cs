using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public Animator myAnimator;

    public void OpenDoor(){
        if (myAnimator.GetBool("bool") == true){
            myAnimator.SetBool("bool", false);
        }
        else
        {
            myAnimator.SetBool("bool", true);
        }
    }
}
