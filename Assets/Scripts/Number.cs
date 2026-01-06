using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class number : MonoBehaviour
{
    int number1 = 10;
    int number2 = 7;
    void Start()
    {
        Debug.Log("hello..");
        Debug.Log(number1);
        Debug.Log(number2);
        int Result = number1 + number2;
        Debug.Log(Result);

        int Result1 = number1 - number2;
        Debug.Log(Result1);
        int Result2 = number1 * number2;
        Debug.Log(Result2);
        int Result3 = number1 / number2;
        Debug.Log(Result3);
        int Result4 = number1 % number2;
        Debug.Log(Result4);

        bool hasil1 = ((1287 * 14+529)>(63*55*5)) && !(21<10);
        Debug.Log(hasil1);

        int temp = number1;
        number1 = number2;
        number2 = temp;

        Debug.Log(number1);
        Debug.Log(number2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}