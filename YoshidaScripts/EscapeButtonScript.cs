using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement; //シーン遷移に絶対必要なおまじない

public class EscapeButtonScript : MonoBehaviour
{
	public void OnClick(){
		//Debug.Log("Button click!");
		SceneManager.LoadScene("ResultScene");
	}

}
