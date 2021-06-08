using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekTwoChallenge : MonoBehaviour
{
    public int answer = 24;

    int higherNumber;
    int otherNumber;

    // Start is called before the first frame update
    void Start()
    {
        int numberOne = Random.Range(1, answer);
        int numberTwo = Random.Range(1, answer);

        if (numberOne > numberTwo)
        {
            higherNumber = numberOne;
            otherNumber = numberTwo;
        }
        else if(numberOne == numberTwo)
        {
            higherNumber = numberOne;
            otherNumber = numberTwo;
        }
        else
        {
            higherNumber = numberTwo;
            otherNumber = numberOne;
        }
        

        if(numberOne + numberTwo == answer)
        {
            Debug.Log("The numbers can be added together to make " + answer + ".");
        }
        else if(higherNumber - otherNumber == answer)
        {
            Debug.Log("The numbers can be subtracted to make " + answer + ".");
        }
        else if(numberOne * numberTwo == answer)
        {
            Debug.Log("The numbers can be multiplied to make " + answer + ".");
        }
        else if(higherNumber / otherNumber == answer)
        {
            Debug.Log("The numbers can be divided to make " + answer + ".");
        }
        else
        {
            Debug.Log("No possible opperation can make " + answer + " from " + numberOne + " and " + numberTwo + ".");
        }
    }
}
