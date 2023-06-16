using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onTrigger : MonoBehaviour
{

    public Animator animator = null;
    private bool isOpen = false;

    void OnTriggerEnter(Collider collider)
    {

         if (collider.name == "01_low_dinningroom")
        {
            //Debug.Log("hit");
            SceneManager.LoadScene("dining-room-i-use");
         }
    }

}



