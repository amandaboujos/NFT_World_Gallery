using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        
    }
    void OnCollisionEnter(Collision gameObjectInformation){
        if (gameObjectInformation.gameObject.name == "XR Origin") {
        Debug.Log ("Collision Detected");
        SceneManager.LoadScene ("Space");
        }

        //Debug.Log(gameObjectInformation.gameObject.name); 
        

    }

}
