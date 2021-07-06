using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week6 : MonoBehaviour
{
    int x = 10;
    int currentNumber = 0;
    int totalSum = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void OddNumberThing()
    {
        for (int i = 0; currentNumber < x; i++)
        {
            print("The current number is: " + currentNumber);
            print("The remainder of the current number / 2 is: " + currentNumber % 2);
            if (currentNumber % 2 == 0)
            {
                currentNumber = currentNumber + 1;
            }
            else
            {
                totalSum += currentNumber;
                currentNumber = currentNumber + 1;
                print("Total sum is: " + totalSum);
            }

            if (currentNumber >= x)
            {
                print("The total sum of all odd numbers from 1 to " + x + " is " + totalSum);
            }
        }
    }
}
