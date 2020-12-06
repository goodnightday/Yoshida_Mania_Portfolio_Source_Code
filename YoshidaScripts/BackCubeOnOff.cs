using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackCubeOnOff : MonoBehaviour
{
    //特定のキーを押すと背景が現れる機能
    public GameObject[] backCubeBox;

    void Update()
    {
        if(Input.GetKey(KeyCode.S)) 
        {
            //Debug.Log("S");
            backCubeBox[0].SetActive (true);
        }else{
            backCubeBox[0].SetActive (false);
        }

        if(Input.GetKey(KeyCode.D)) 
        {
            //Debug.Log("D");
            backCubeBox[1].SetActive (true);
        }else{
            backCubeBox[1].SetActive (false);
        }
        if(Input.GetKey(KeyCode.F)) 
        {
            //Debug.Log("F");
            backCubeBox[2].SetActive (true);
        }else{
            backCubeBox[2].SetActive (false);
        }

        if(Input.GetKey(KeyCode.J)) 
        {
            //Debug.Log("J");
            backCubeBox[3].SetActive (true);
        }else{
            backCubeBox[3].SetActive (false);
        }
        if(Input.GetKey(KeyCode.K)) 
        {
            //Debug.Log("K");
            backCubeBox[4].SetActive (true);
        }else{
            backCubeBox[4].SetActive (false);
        }

        if(Input.GetKey(KeyCode.L)) 
        {
            //Debug.Log("L");
            backCubeBox[5].SetActive (true);
        }else{
            backCubeBox[5].SetActive (false);
        }
    }

}
