using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.Rendering;

public class SignalReceiver : MonoBehaviour
{
    public Material NextSkybox;

    public void EmiterToChangeSkybox(){ 
        RenderSettings.skybox = NextSkybox;
    }

}
