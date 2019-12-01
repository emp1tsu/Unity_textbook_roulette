using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    // 回転速度
    float rotSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 左クリックされたら回転速度設定
        if(Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }

        // 回転速度分ルーレットを回転
        transform.Rotate(0, 0, this.rotSpeed);

        // ルーレット原則
        this.rotSpeed *= 0.96f;
    }
}
