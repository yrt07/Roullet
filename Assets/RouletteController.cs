using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; //��]���x
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
        //�}�E�X�������ꂽ��A��]���x��ݒ肷��
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
            brake = false;
        }
        if(Input.GetMouseButtonDown(1))
        {
            brake = true;
        }

        //��]���x���A���[���b�g����]������
        transform.Rotate(0, 0, this.rotSpeed);
        �@�@
        //���[���b�g������������
        if(brake)
        {
            this.rotSpeed *= 0.98f;
        }
        
    }

}
