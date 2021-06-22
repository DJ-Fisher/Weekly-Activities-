using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int year = 5003;
        float degreesFar = Random.Range(20, 122);
        LeapYears(year);
        Conversions(degreesFar);
        print("it is " + Conversions(degreesFar) + " degrees Celcius");

        if (Conversions(degreesFar) < 0)
        {
            print("It is freezing weather");
        }
        else if (Conversions(degreesFar) >= 0 && Conversions(degreesFar) < 10)
        {
            print("It is very cold weather");
        }
        else if (Conversions(degreesFar) >= 11 && Conversions(degreesFar) <= 20)
        {
            if (Conversions(degreesFar) <= 13 || Conversions(degreesFar) == 14)
            {
                print("It is a bit cool");
            }
            else
            {
                print("It's cold weather");
            }
        }
        else if (Conversions(degreesFar) >= 21 && Conversions(degreesFar) < 30)
        {
            print("It is average tempreature");
        }
        else if (Conversions(degreesFar) >= 31 && Conversions(degreesFar) < 40)
        {
            if(Conversions(degreesFar) < 35)
            {
                print("It's a nice Queensland day!");
            }
            else if(Conversions(degreesFar) < 37 && Conversions(degreesFar) > 35)
            {
                print("It's getting warmer");
            }
            else
            {
                print("It's Hot");
            }
        }
        else if(Conversions(degreesFar) >= 40)
        {
            print("It's very hot!");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LeapYears(int Year)
    {
        if(Year % 4 == 0)
        {
            print("The year is a leap year");
        }
        else
        {
            print("The year is not a leap year");
        }
    }

    public float Conversions(float tempFahrenheit)
    {
        float tempCelsius = (tempFahrenheit - 32) * 5/9;

        return tempCelsius;
    }
    
}

