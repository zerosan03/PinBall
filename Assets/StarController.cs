using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{

    // ��]���x
    private float rotSpeed = 0.5f;

    // Use this for initialization
    void Start()
    {
        //��]���J�n����p�x��ݒ�
        this.transform.Rotate(0, Random.Range(0, 360), 0);
    }

    // Update is called once per frame
    void Update()
    {
        //��]
        this.transform.Rotate(0, this.rotSpeed, 0);
    }
}