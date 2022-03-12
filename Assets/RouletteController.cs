using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; //回転速度
    public bool brake;

    // Start is called before the first frame update
    void Start()
    {
        brake = false;

    }

    public void StartBottonDown()
    {
        this.rotSpeed = 10;
        brake = false;

    }

    public void StopBottonDown()
    {
        //this.rotSpeed *= 0.98f;
        brake = true;
    }


    // Update is called once per frame
    void Update()
    {
        //マウスが押されたら、回転速度を設定する
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
            brake = false;
        }
        if(Input.GetMouseButtonDown(1))
        {
            brake = true;
        }

        //回転速度分、ルーレットを回転させる
        transform.Rotate(0, 0, this.rotSpeed);
        　　
        //ルーレットを減速させる
        if(brake)
        {
            this.rotSpeed *= 0.98f;
        }
        
    }

}
