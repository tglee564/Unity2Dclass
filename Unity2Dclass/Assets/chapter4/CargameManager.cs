using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CargameManager : MonoBehaviour
{
    CarController carController;

    GameObject car;
    GameObject flag;
    GameObject distanceText;

    public int LifeNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distanceText = GameObject.Find("distance");

        carController = car.GetComponent<CarController>();
    }
    
    // Update is called once per frame
    void Update()
    {
        float length = flag.transform.position.x - car.transform.position.x;

        distanceText.GetComponent<TMP_Text>().text = "Distance : " + length.ToString("F2") + "m"; // F2 -> 소수점 2번째 자리까지.
        
        
    }
}
