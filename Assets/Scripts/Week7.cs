using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week7 : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        FizzBuzz(1,100);
    }


    /// <param name="currentNumber"></param>
    /// <param name="maxNumber"></param>
    public void FizzBuzz(int currentNumber, int maxNumber)
    {
        for(int i = currentNumber; i < maxNumber + 1; i++)
        {
            if (currentNumber % 3 == 0 && currentNumber % 5 == 0)
            {
                print("FizzBuzz");
            }
            else if (currentNumber % 3 == 0)
            {
                print("Fizz");
            }
            else if(currentNumber % 5 == 0)
            {
                print("Buzz");
            }
            else
            {
                print(currentNumber);
            }
            currentNumber += 1;
        }
    }
}
