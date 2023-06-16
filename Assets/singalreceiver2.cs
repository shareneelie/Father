using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.Rendering;

public class singalreceiver2 : MonoBehaviour
{

    public string sceneName;
    public void EmiterToLoadScene(){
        //Debug.Log("receive");
        SceneManager.LoadScene(sceneName);
    }
}

