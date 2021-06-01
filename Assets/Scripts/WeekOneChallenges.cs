using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekOneChallenges : MonoBehaviour
{
    // Start is called before the first frame update

    public string myName = "DJ";
    public int age = 18;
    public int birthDay = 30;
    public int birthMonth = 01;
    public int birthYear = 2003;
    public int HeightCm = 173;

    //used to select the right words for the finished statement.
    public bool amWearingWatch = false;
    public int favNumber = 5;
    public int sumOfAgeAndNumber;

    //used as placeholders to select the correct text when debuged out.
    public string watchClause;
    public string rumourClause;

    void Start()
    {  
        //grabs the sum of the age and favorite number, self explanatory.
        sumOfAgeAndNumber = age + favNumber;

        //simple if/else statement used to switch the words used in the final statement according to the amWearingWatch bool
        if(amWearingWatch == true)
        {
            watchClause = " am";
            rumourClause = "true";
        }
        else
        {
            watchClause = "am not";
            rumourClause = "false";
        }
        
        //the full statement debug.
        Debug.Log("Greetings, my name is " + myName + ", my age in years is " + age + ", and that means my date of birth is " + birthDay + " " + birthMonth + 
            " " + birthYear + ", I am " + HeightCm + "cm tall and in case you are wondering, the rumours are " + rumourClause + " I " + watchClause + 
            " wearing a watch. Finally my favorite number is " + favNumber + " and if that is added to my age that will give me " + sumOfAgeAndNumber + ".");   

    }
}
