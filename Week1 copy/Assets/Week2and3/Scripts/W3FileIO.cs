
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; //to write to a file, we need the System.IO library

public class W3FileIO : MonoBehaviour
{
    //the name of our file
    //we're making it a const because it's a variable that really never needs to change
    //you must include the file ending
    const string FILE_NAME = "Week3Save.txt";

    string content;

    // splits strings up so we can use parts of a string separately
    // this is a char i can use to delimit parts of a string
    const char DELIMITER = '|';

    //normally these are pulled from the game for us to use, but its hardcoded rn just as an example
    string playerName = "Sophie";
    int score = 1000;
    string country = "US";

    const char COUNTRY_DELIMITER = '$';

    // Start is called before the first frame update
    void Start()
    {
        //open the stream writer with the file we want to write to
        //if the file doesn't exist, the stream writer will create it
        //the bool at the end decides if we apend to the file
        //false == overwrite the file
        //true == add to the file
        StreamWriter writer = new StreamWriter(FILE_NAME, false);
        //write to the file
        writer.Write(playerName + DELIMITER + score + COUNTRY_DELIMITER + country);
        //close the stream writer
        writer.Close();

        //open the stream reader
        StreamReader reader = new StreamReader(FILE_NAME);
        //read the line the stream is on
        //lines end with /n in text
        //(we'll go over this in week 4)
        content = reader.ReadLine();

        // makes an array of potential delimiters
        char[] delimiterChars = { '|', '$'};
        // every time i see a delimiter, split it so i can use the split up compenents from the string
        string[] scoreSplit = content.Split(delimiterChars);

        for (int i = 0; i < scoreSplit.Length; i++)
        {
            // & checks for remainders - so in this case if the remainder is 0 after dividing by 2, then do this
            // & is called modulo
            if(i%3 == 0)
            {
                Debug.Log("is a name");
            }
            else if (i%2 == 0)
            {
                Debug.Log("is a country");
            }
            else
            {
                Debug.Log("is a score");
            }
        }

        //int allHighScores = 100 + scoreSplit[1];
        int highScore = int.Parse(scoreSplit[1]);
        int allHighScores = 100 + highScore;

        Debug.Log("name: " + scoreSplit[0]);
        Debug.Log("score: " + scoreSplit[1]);
        //print the line to the console
        //Debug.Log(content);
        //close the reader
        reader.Close();
    }

    void Update()
    {
        //Debug.Log(content);
    }
}
