using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //キューブの移動速度
    private float speed = -12;
    //消滅位置
    private float deadLine = -10;

    //課題音で追加
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //課題音で追加　コンポーネントを取得
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //キューブを左に移動させる
        //Translate関数は、引数に与えた値のぶんだけ現在の位置から移動する。※指定した値の座標に移動するわけではない
        //第一引数から順にX軸方向、Y軸方向、Z軸方向の移動距離を指定
        //Time.deltaTime：前フレームからの経過時間。距離＝速さ×時間だから？
        transform.Translate(this.speed * Time.deltaTime, 0, 0);
        //画面外に出たら破棄する
        if(transform.position.x < this.deadLine) {
            Destroy(gameObject);
        }

    }

    //課題で追加
    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("UnityChan")) {
            Debug.Log("ユニティちゃんに当たった");
        }
        else {
            Debug.Log("ブロックor地面に当たった");
            audioSource.Play();
        }
    }
}
