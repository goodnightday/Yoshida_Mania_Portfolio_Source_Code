using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement; //シーン遷移に絶対必要なおまじない

public class StartScript : MonoBehaviour
{
	void Start(){//スマホ画面の調整
		Screen.orientation = ScreenOrientation.AutoRotation;
        Screen.autorotateToPortrait = false; // 縦
        Screen.autorotateToLandscapeLeft = true; // 左
        Screen.autorotateToLandscapeRight = true; // 右
        Screen.autorotateToPortraitUpsideDown = false; // 上下逆
	}
    void Update()
    {
    	if (Input.GetMouseButtonDown (0)){
    		SceneManager.LoadScene("MusicSelectScene");
            
        }


        if(Input.GetKey(KeyCode.Escape)){
            SceneManager.LoadScene("ResultScene");
        } 
        
    }
}
