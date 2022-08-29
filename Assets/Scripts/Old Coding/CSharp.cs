using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSharp : MonoBehaviour
{
    int a = 2;
    int b = 4;

    int answer;

    // Start is called before the first frame update
    void Start()
    {
        //            2 + 4 = 6
        answer = a + b;
       

        //            4 - 2 = 2
        answer = b - a;


        //            4 * 2 = 8
        answer = b * a;


        //            4 / 2 = 2
        answer = b / a;


        if(a > b)
        {
            // a is bigger than b
        }
        else
        {
            // a is not bigger than b
        }


        if(a > b)
        {
            // a is bigger than b
        }
        else if(a == b)
        {
            // a and b are equal
        }
        else
        {
            // b is bigger than a 
        }


        if( a >= b)
        {
            // a is bigger or equal to b
        }

        if(a != b)
        {
            // a is not equal to b
        }


        // if a is 10 AND b is 5
        if(a == 2 && b == 4)
        {
            // a is 10 and b is 5
        }


        // if a is 10 or b is 5
        if (a == 2 || b == 4)
        {
            // either a is 10 or b is 5
        }

               
        switch (a)
        {
            case 2:
                Debug.Log("a equals 2 ");
                break;
            case 4:
                Debug.Log("a equals 4");
                break;
            default:
                Debug.Log("Default case");
                break;
        }


        // for as long as i is less than b, do this code, then and 1 to i
        for (int i = 0; i < b; i++)
        {
            Debug.Log(i);
        }


        // if i is equal to a, break out of the loop
        for (int i = 0; i < b; i++)
        {
            if(i == a)
            {
                break;
            }
        }


        // while a is less than b, add 1 to the value of a
        while (a < b)
        {
            // ( a = a + 1)
            a++;
        }



        answer = Add(a, b);

    }


    private int Add(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }

}
