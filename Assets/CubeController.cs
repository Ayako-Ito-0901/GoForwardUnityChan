using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //キューブの移動速度
    private float speed = -12;
    //消滅位置
    private float deadLine = -10;

    // Start is called before the first frame update
    void Start()
    {
        
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
}
