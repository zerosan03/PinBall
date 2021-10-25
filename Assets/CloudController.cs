using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{

    //�ŏ��T�C�Y
    private float minimum = 1.0f;
    //�g��k���X�s�[�h
    private float magSpeed = 10.0f;
    //�g�嗦
    private float magnification = 0.07f;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //�_���g��k��
        this.transform.localScale = new Vector3(this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification, this.transform.localScale.y, this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification);

    }
}