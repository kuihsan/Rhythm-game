using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepScript : MonoBehaviour
{
    public AudioSource footstepsSound;// sprintSound;

    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            if (Input.GetKey(KeyCode.LeftShift))
            {
                footstepsSound.enabled = false;
                //sprintSound.enabled = true;
            }
            else
            {
                footstepsSound.enabled = true;
                //sprintSound.enabled = false;
            }
        }
        else
        {
            footstepsSound.enabled = false;
            //sprintSound.enabled = false;
        }
    }
}