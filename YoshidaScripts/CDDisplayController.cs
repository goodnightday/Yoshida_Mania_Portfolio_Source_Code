using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//using System.Collections.Generic;//listを使えるようにする

public class CDDisplayController : MonoBehaviour {

    private int CDNum = 0;

    public GameObject wingOFPIANO;
    //= new GameObject("Wings of pianoCD")
    public GameObject positiveForce;
    public GameObject daedalus;
    public GameObject daddyMulkGrooveRemix;
    private GameObject[] gameObjects;

    //public GameObject[] gameObjects = new GameObject []{Wing OF PIANO,Positive Force,aa,bb};

    //private List<GameObject> gameObjects = new List<GameObject>();




    public AudioClip audioClip1;
    public AudioClip audioClip2;
    public AudioClip audioClip3;
    public AudioClip audioClip4;

    private AudioSource audioSource;


    void Start () {
        gameObjects = new GameObject []{wingOFPIANO,positiveForce,daedalus,daddyMulkGrooveRemix};



        //gameObjects[CDNum].SetActive(true);
        GameController.musicNumber = 0;

         audioSource = gameObject.GetComponent<AudioSource>();
         audioSource.clip = audioClip1;
         audioSource.Play();

    }
	
	

    public void RightButtonDown()
    {
        gameObjects[CDNum].SetActive(false);
        CDNum ++;
        if (CDNum == 4)
        {
            CDNum = 0;
        }
        gameObjects[CDNum].SetActive(true);
        //Shake(gameObjects[CDNum]);
        GameController.musicNumber = CDNum;

        switch (CDNum)
        {
            case 0:
                audioSource.clip = audioClip1;
                audioSource.time = 20f;
                audioSource.Play();
                break;
            case 1:
                audioSource.clip = audioClip2;
                audioSource.Play();
                break;
            case 2:
                audioSource.clip = audioClip3;
                audioSource.Play();
                break;
            case 3:
                audioSource.clip = audioClip4;
                audioSource.time = 2f;
                audioSource.Play();
                break;
            default:
                break;

        }
   }
 

    public void LeftButtonDown()
    {
        gameObjects[CDNum].SetActive(false);
        CDNum -= 1;
        if (CDNum < 0)
        {
            CDNum = 3;
        }
        gameObjects[CDNum].SetActive(true);
        //Shake2(gameObjects[CDNum]);
        GameController.musicNumber = CDNum;

        switch (CDNum)
        {
            case 0:
                audioSource.clip = audioClip1;
                audioSource.time = 20f;
                audioSource.Play();
                break;
            case 1:
                audioSource.clip = audioClip2;
                audioSource.Play();
                break;
            case 2:
                audioSource.clip = audioClip3;
                audioSource.Play();
                break;
            case 3:
                audioSource.clip = audioClip4;
                audioSource.time = 2f;
                audioSource.Play();
                break;
            default:
                break;

        }

    }



    public void StartGame()
    {

        SceneManager.LoadScene("GameScene");
    }

    // public void Shake(GameObject shakeObj)
    // {
    //     //iTween.ShakePosition(shakeObj, iTween.Hash("x", 0.5f, "y", 0.5f, "time", 0.5f));
    //     iTween.RotateFrom(shakeObj, iTween.Hash("z", 90,"islocal",true, "time", 0.2f));
    // }

    // public void Shake2(GameObject shakeObj) {
    //     //iTween.ShakePosition(shakeObj, iTween.Hash("x", 0.5f, "y", 0.5f, "time", 0.5f));
    //     iTween.RotateFrom(shakeObj, iTween.Hash("z", -90, "islocal", true, "time", 0.2f));
    // }


}
