using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onTrigger2 : MonoBehaviour
{

    public string sceneName;
    public GameObject obj;

    void OnTriggerEnter(Collider collider)
    {
        
         if (collider.name == obj.GetComponent<Collider>().name){
            Debug.Log(obj.GetComponent<Collider>().name);
            SceneManager.LoadScene(sceneName);
         }
    }

}



