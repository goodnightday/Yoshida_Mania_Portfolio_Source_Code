using System.Collections;
using UnityEngine;

public class NotesScript : MonoBehaviour {//落下するノーツにくっつけている

    public int lineNum;
    public int comboNum;

    private GameController _gameController;
    public bool isInLine = false;
    private KeyCode _lineKey;


    


    //プロパティー
    // public bool IsInLine{
    //     get{ return this.isInLine; }  //取得用
    //     set{ this.isInLine = value; }　//値入力用
    // }




    void Start () {
        _gameController = GameObject.Find ("GameController").GetComponent<GameController> ();//Findして_gameControllerに格納
        _lineKey = GameUtil.GetKeyCodeByLineNum(lineNum);
    }

    void Update () {
        this.transform.position += Vector3.down * 10 * Time.deltaTime;

        if (this.transform.position.y < -1.5f) {//一定のラインにいくと消える
            //Debug.Log ("false");
            Destroy (this.gameObject);
            
            _gameController.GetComponent<GameController>().ComboMiss();
        }

        if(isInLine){
            CheckInput(_lineKey);
        }
        if(isInLine && NotesHitCheck.notesHitCheck0){//携帯用タップ当たり判定
            if (this.gameObject.CompareTag("Notes tag 0"))
            {
                NotesBreak();
            }
            NotesHitCheck.notesHitCheck0 = false;
            NotesHitCheck.isInLine0 = false;
        }

        if(isInLine && NotesHitCheck.notesHitCheck1){//携帯用タップ当たり判定
            if (this.gameObject.CompareTag("Notes tag 1"))
            {
                NotesBreak();
            }
            NotesHitCheck.notesHitCheck1 = false;
            NotesHitCheck.isInLine1 = false;
        }

        if(isInLine && NotesHitCheck.notesHitCheck2){//携帯用タップ当たり判定
            if (this.gameObject.CompareTag("Notes tag 2"))
            {
                NotesBreak();
            }
            NotesHitCheck.notesHitCheck2 = false;
            NotesHitCheck.isInLine2 = false;
        }

        if(isInLine && NotesHitCheck.notesHitCheck3){//携帯用タップ当たり判定
            if (this.gameObject.CompareTag("Notes tag 3"))
            {
                NotesBreak();
            }
            NotesHitCheck.notesHitCheck3 = false;
            NotesHitCheck.isInLine3 = false;
        }

        if(isInLine && NotesHitCheck.notesHitCheck4){//携帯用タップ当たり判定
            if (this.gameObject.CompareTag("Notes tag 4"))
            {
                NotesBreak();
            }
            NotesHitCheck.notesHitCheck4 = false;
            NotesHitCheck.isInLine4 = false;
        }

        if(isInLine && NotesHitCheck.notesHitCheck5){//携帯用タップ当たり判定
            if (this.gameObject.CompareTag("Notes tag 5"))
            {
                NotesBreak();
            }
            NotesHitCheck.notesHitCheck5 = false;
            NotesHitCheck.isInLine5 = false;
        }
    }

    void OnTriggerStay (Collider other) {//ノーツがイズラインとぶつかっていたらトゥルー
        isInLine = true;
    }

    void OnTriggerExit (Collider other) {//ノーツがイズラインと離れたらフォルス
        isInLine = false;
    }

    void CheckInput (KeyCode key) {

        if (Input.GetKeyDown (key)) {//本来はゲットキーダウンにする。難易度低下はGetKey
            _gameController.GoodTimingFunc (lineNum);
            Destroy (this.gameObject);
        }
    }

    public void NotesBreak(){
        _gameController.GoodTimingFunc (lineNum);
        Destroy (this.gameObject);

    }


}