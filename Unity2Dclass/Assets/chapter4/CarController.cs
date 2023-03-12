using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CarController : MonoBehaviour
{
    float Speed = 0;
    Vector2 StartPos;
    GameObject result;

    public float Length;
    public int lifenumber = 0;


    // Start is called before the first frame update
    void Start()
    {
        result = GameObject.Find("result");
    }

    // Update is called once per frame
    void Update()
    {
        if(result.GetComponent<TMP_Text>().text != "Win!" || result.GetComponent<TMP_Text>().text != "Lose!")
        {
            if (lifenumber < 5)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Debug.Log("down");
                    StartPos = Input.mousePosition;
                }
                else if (Input.GetMouseButtonUp(0))
                {
                    Debug.Log("Up");
                    Vector2 endPos = Input.mousePosition;
                    Length = endPos.x - StartPos.x;

                    Speed = Length / 500.0f;

                    GetComponent<AudioSource>().Play();
                    lifenumber++;
                }
                transform.Translate(Speed, 0, 0);
                Speed *= 0.98f;
            }
            if(lifenumber < 5)
            {
                if (Length <= 0.5f && Length > 0)
                {
                    result.GetComponent<TMP_Text>().text = "Win!";
                }
                else if (Length > 0.5f || Length < 0)
                {
                    result.GetComponent<TMP_Text>().text = $"Life {5 - lifenumber}!";
                }
            }
            else if(lifenumber == 5)
            {
                result.GetComponent<TMP_Text>().text = "Lose!";
            }
        }
    }
}
