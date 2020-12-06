using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesHitCheck : MonoBehaviour
{
	public static bool notesHitCheck0 = false;
	public static bool notesHitCheck1 = false;
	public static bool notesHitCheck2 = false;
	public static bool notesHitCheck3 = false;
	public static bool notesHitCheck4 = false;
	public static bool notesHitCheck5 = false;

	public static bool isInLine0 = false;
	public static bool isInLine1 = false;
	public static bool isInLine2 = false;
	public static bool isInLine3 = false;
	public static bool isInLine4 = false;
	public static bool isInLine5 = false;
    


    void OnTriggerStay (Collider other) {//ノーツがイズラインとぶつかっていたらトゥルー
    	if (this.gameObject.CompareTag("Line tag 0")){
            isInLine0 = true;
        }
        if (this.gameObject.CompareTag("Line tag 1")){
            isInLine1 = true;
        }
        if (this.gameObject.CompareTag("Line tag 2")){
            isInLine2 = true;
        }
        if (this.gameObject.CompareTag("Line tag 3")){
            isInLine3 = true;
        }
        if (this.gameObject.CompareTag("Line tag 4")){
            isInLine4 = true;
        }
        if (this.gameObject.CompareTag("Line tag 5")){
            isInLine5 = true;
        }
        //Debug.Log("true");
    }

    void OnTriggerExit (Collider other) {//ノーツがイズラインと離れたらフォルス
        if (this.gameObject.CompareTag("Line tag 0")){
            isInLine0 = false;
        }
        if (this.gameObject.CompareTag("Line tag 1")){
            isInLine1 = false;
        }
        if (this.gameObject.CompareTag("Line tag 2")){
            isInLine2 = false;
        }
        if (this.gameObject.CompareTag("Line tag 3")){
            isInLine3 = false;
        }
        if (this.gameObject.CompareTag("Line tag 4")){
            isInLine4 = false;
        }
        if (this.gameObject.CompareTag("Line tag 5")){
            isInLine5 = false;
        }
        //Debug.Log("false");

    }
    public void NotesHitCheck0(){
    	if(isInLine0){
    		notesHitCheck0 = true;
    		//Debug.Log("HitClick0");
    	}
    }
    public void NotesHitCheck1(){
    	//Debug.Log("Click");
    	if(isInLine1){
    		notesHitCheck1 = true;
    		Debug.Log("HitClick1");
    	}
    }
    public void NotesHitCheck2(){
    	//Debug.Log("Click");
    	if(isInLine2){
    		notesHitCheck2 = true;
    		Debug.Log("HitClick2");
    	}
    }
    public void NotesHitCheck3(){
    	//Debug.Log("Click");
    	if(isInLine3){
    		notesHitCheck3 = true;
    		Debug.Log("HitClick3");
    	}
    }
    public void NotesHitCheck4(){
    	//Debug.Log("Click");
    	if(isInLine4){
    		notesHitCheck4 = true;
    		Debug.Log("HitClick4");
    	}
    }
    public void NotesHitCheck5(){
    	//Debug.Log("Click");
    	if(isInLine5){
    		notesHitCheck5 = true;
    		Debug.Log("HitClick5");
    	}
    }
    
}
