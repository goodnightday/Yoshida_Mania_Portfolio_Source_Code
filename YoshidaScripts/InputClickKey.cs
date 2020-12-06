using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputClickKey : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetKeyS(){
    	Input.GetKey(KeyCode.S);
    	Debug.Log("S");
    }
}
