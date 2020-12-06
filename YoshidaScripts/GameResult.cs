using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class GameResult : MonoBehaviour
{

	public Text MusicTitle;
    public Text TotalScore;
	public Text ComboScore;

	private int totalScore = 0;
    private int comboScore = 0;
    private string musicTitle = "None";

	//private GameController _gameController;




    void Start()
    {

        totalScore = GameController._score;
        comboScore = GameController.maxCombo;

       
        Debug.Log(totalScore);
        Debug.Log(comboScore);


        TotalScore.text = "TotalScore : " + totalScore.ToString ();//int型の変数をString型にキャストしている
        ComboScore.text = "MaxCombo : " + comboScore.ToString ();//int型の変数をString型にキャストしている


        switch (GameController.musicNumber) {//musicNumberが特定の数値であれば曲を変える
            case 0:
                musicTitle = "Wing OF PIANO";
                break;
            case 1:
                musicTitle = "Positive Force";
                break;
            case 2:
                musicTitle = "Daedalus";
                break;
            case 3:
                musicTitle = "Daddy Mulk Groove Remix";
                break;
            default:
                break;
        }

        MusicTitle.text = "MusicTitle : " + musicTitle.ToString ();
    }
}
