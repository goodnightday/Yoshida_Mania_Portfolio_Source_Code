using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement; //シーン遷移に絶対必要なおまじない


public class ReturnGameSceneScript : MonoBehaviour
{


    public void OnClick(){
		//Debug.Log("Button click!");
		SceneManager.LoadScene("MusicSelectScene");
	}

	void Update () {

        if(Input.GetKey(KeyCode.Escape)){
            SceneManager.LoadScene("MusicSelectScene");
        }    
    }
}
