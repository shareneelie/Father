using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleportToScene : MonoBehaviour
{
    public string scenename;
    void OnTriggerEnter(Collider collider)
    {
         if (collider.name == "01_low_dinningroom")
        {
            SceneManager.LoadScene(scenename);
         }
    }

}



