using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        // If the instance doesn't exist...
        if (instance == null)
        {
            // ...set the instance to this object...
            instance = this;
            // ...and don't destroy this object when loading a new scene
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // ...otherwise, instance exists already, so destroy gameObject
            Destroy(gameObject);
        }
    }
}
