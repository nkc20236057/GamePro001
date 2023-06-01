using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OmemeController : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    void Update()
    {
        //フレームごとに等速で落下せせる
        transform.Translate(-0.1f, 0, 0);

        //画面外に出たらオブジェクトを破棄(Destroy)する
        if (transform.position.x < -11.0f)
        {
            Destroy(gameObject);
        }

        //当たり判定
        Vector2 p1 = transform.position;                 //中心座標
        Vector2 p2 = this.player.transform.position;     //プレイヤーの中心座標
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;         //半径
        float r2 = 1.0f;

        if(d < r1 + r2)
        {
            //監督スクリプトにプレイヤと衝突したことを伝える
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHP();

            Destroy (gameObject);
        }
    }
}
