using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerDetection : MonoBehaviour
{
    public string sceneToLoad;
    public void OnTriggerEnter2D(Collider2D colider) {
        if (colider.gameObject.tag == "Player") {
            SceneManager.LoadScene(sceneToLoad);
            //hgjkgfkhgdfkhgdfhgdf
        }
    } 
}

//hjfjgf