using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RulletControl : MonoBehaviour
{

    float rotSpeed = 0; // ȸ���ӵ�

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Debug.Log("���콺 Ŭ�� �Է�");
            rotSpeed += 10;
        }

        transform.Rotate(0, 0, rotSpeed);
        rotSpeed *= 0.98f;

        if(rotSpeed < 0.01f && rotSpeed != 0)
        {
            Debug.Log($"{transform.rotation.eulerAngles.z}");

            if (transform.rotation.eulerAngles.z % 360 + 30 <= 60)
            {
                Debug.Log("��� ����");
            }
            else if (transform.rotation.eulerAngles.z % 360 + 30 <= 120)
            {
                Debug.Log("��� ����");
            }
            else if (transform.rotation.eulerAngles.z % 360 + 30 <= 180)
            {
                Debug.Log("��� �ſ� ����");
            }
            else if (transform.rotation.eulerAngles.z % 360 + 30 <= 240)
            {
                Debug.Log("��� ����");
            }
            else if (transform.rotation.eulerAngles.z % 360 + 30 <= 300)
            {
                Debug.Log("��� ����");
            }
            else
            {
                Debug.Log("��� ����");
            }
            rotSpeed = 0;
        }



    }
}
