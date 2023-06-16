using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleport_dinning : MonoBehaviour
{
    public string scenename;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "croissant")
        {
            SceneManager.LoadScene(scenename);
        }
    }

}
