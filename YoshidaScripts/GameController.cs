using UnityEngine;
using System.Collections;
using System.IO;
using System;
using UnityEngine.UI;

using UnityEngine.SceneManagement; //シーン遷移に絶対必要なおまじない


public class GameController : MonoBehaviour {//ゲーム全体を司る 空のオブジェクトに入る
    
    public static int musicNumber = 0;        

    public GameObject[] notes;
    private float[] _timing;
    private int[] _lineNum;

    public string filePass;
    private int _notesCount = 0;

    private AudioSource _audioSource;
    private float _startTime = 0;

    public float timeOffset = -1;

    private bool _isPlaying = false;
    //public GameObject startButton;

    public Text scoreText;
    public static int _score = 0;

    public static int getScore() {
        return _score;
    }

    public Text comboText;
    public static int comboScore = 0;

    public static int getComboScore() {
        return comboScore;
    }

    public static int maxCombo = 0;

    public NotesScript notesScript;


    public static bool isClear = true;

    public AudioClip audioClip1;
    public AudioClip audioClip2;
    public AudioClip audioClip3;
    public AudioClip audioClip4;
    public AudioClip audioClip5;

    public Text SuccessText;
    private String successJudgment;

    public AudioClip tambourine;//タンバリンの音


    void Start(){
        _audioSource = GameObject.Find ("GameMusic").GetComponent<AudioSource> ();
        _timing = new float[1024];
        _lineNum = new int[1024];
        LoadCSV ();
        StartGame();
        maxCombo = 0;
        _score = 0;
        comboScore =0;


    }

    void Update () {
        if (_isPlaying) {
            CheckNextNotes ();
            scoreText.text = _score.ToString ();

        } 
        if (!_audioSource.isPlaying && _isPlaying) {//曲が止まっていて _isPlayingがtrueならリザルト画面に遷移
            SceneManager.LoadScene("ResultScene");
        }

        if(Input.GetKey(KeyCode.Escape)){
            SceneManager.LoadScene("ResultScene");
        }

        if(Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.F)||Input.GetKey(KeyCode.J)||Input.GetKey(KeyCode.K)||Input.GetKey(KeyCode.L)) 
        {
            _audioSource.PlayOneShot(tambourine);
        }
              
    }

    public void StartGame(){
        //startButton.SetActive (false);
        //_startTime = Time.time;
        switch (musicNumber) {//musicNumberが特定の数値であれば曲を変える
            case 0:
                _audioSource.clip = audioClip1;
                break;
            case 1:
                _audioSource.clip = audioClip2;
                break;
            case 2:
                _audioSource.clip = audioClip3;
                break;
            case 3:
                _audioSource.clip = audioClip4;
                break;
            default:
                break;
        }
        _startTime = Time.time;//一応位置下に移動した
        _audioSource.Play ();
        _isPlaying = true;
    }

    void CheckNextNotes(){
        while (_timing [_notesCount] + timeOffset < GetMusicTime () && _timing [_notesCount] != 0) {
            SpawnNotes (_lineNum[_notesCount]);
            _notesCount++;
        }
    }

    void SpawnNotes(int num){
        Instantiate (notes[num], 
            new Vector3 (-5.5f + (2.0f * num), 10.0f, 0),
            Quaternion.identity);
    }

    void LoadCSV(){
        int i = 0, j;
        //TextAsset csv = Resources.Load (filePass) as TextAsset;//ファイルごと読み込んでいたっぽい

        TextAsset csv = new TextAsset();

        
        switch (musicNumber) {//musicNumberが特定の数値であれば読み込む曲を変える
            case 0:
                csv = Resources.Load("Wings of piano", typeof(TextAsset) )as TextAsset; 
                break;
            case 1:
                csv = Resources.Load("Positive Force", typeof(TextAsset) )as TextAsset; 
                break;
            case 2:
                csv = Resources.Load("Daedalus", typeof(TextAsset) )as TextAsset; 
                break;
            case 3:
                csv = Resources.Load("Daddy Mulk Groove Remix", typeof(TextAsset) )as TextAsset; 
                break;
            default:
                csv = Resources.Load("Wings of piano", typeof(TextAsset) )as TextAsset; 
                break;
        }

        StringReader reader = new StringReader (csv.text);
        while (reader.Peek () > -1) {

            string line = reader.ReadLine ();
            string[] values = line.Split (',');
            for (j = 0; j < values.Length; j++) {
                _timing [i] = float.Parse( values [0] );
                _lineNum [i] = int.Parse( values [1] );
            }
            i++;
        }
    }

    float GetMusicTime(){
        return Time.time - _startTime;
    }

    public void GoodTimingFunc(int num){
        //Debug.Log ("Line:" + num + " good!");
        
        //Debug.Log (GetMusicTime());

        _score++;
        comboScore++;

        successJudgment = "Good";

        SuccessText.text = successJudgment.ToString ();


        ComboCount(comboScore);
        MaxComboCheck(comboScore);
    }

    public void ComboCount(int comboScore){//もしも連続でグッドが５回以上出たときコンボを表示コンボが４回以下なら非表示
        if(comboScore > 4){
            comboText.enabled = true;
            //Debug.Log("Combo" + comboScore);
            comboText.text = comboScore.ToString ()　+ "Combo!";

        }
    }
    public void MaxComboCheck(int comboScore){
        
        if(comboScore > maxCombo){
            maxCombo++;
            //Debug.Log(maxCombo);
        }

    }

    public int ComboMiss(){
        comboScore = 0;
        comboText.enabled = false;//コンボの表示をオフ
        successJudgment = "Miss";
        SuccessText.text = successJudgment.ToString ();
        return comboScore;
    }

    public void Tambourine(){
        _audioSource.PlayOneShot(tambourine);
    }






    //透明な箱をラインの下に作るそれに触れたらバッド判定
    //バッどならコンボカウント０
}