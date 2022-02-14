using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class W4ASCIILevelLoader : MonoBehaviour
{
    public string fileName;

    public float xOffset;
    public float yOffset;

    // Start is called before the first frame update
    void Start()
    {
        StreamReader reader = new StreamReader(fileName);
        // makes sure it reads every single line
        string contentOfFile = reader.ReadToEnd();
        reader.Close();

        //Debug.Log(contentOfFile);

        // \n is where theres no new character - techniclly theres an invisible one at the end of every line
        char[] newLineChar = { '\n' };

        string[] level = contentOfFile.Split(newLineChar);

        //we're treating the string like an array rn
        for (int 1 = 0; i < level.Length; i++)
        {
            MakeRow(level[i], -i);
        }
    }

    // Update is called once per frame
    void MakeRow(string rowStr, float y)
    {

        char[] rowArray = rowStr.ToCharArray();
        for (int x = 0; x < rowStr.Length; x++)
        {
            if (c == 'X') {
                char c = contentOfFile[i];
                Debug.Log("make a cube");
                GameObject brick = Instantiate(Resources.Load("Brick") as GameObject);
                brick.transform.position = new Vector3(
                    x * brick.transform.localScale.x + xOffset,
                    y * brick.transform.localScale.y + yOffset,
                    0
                    );
            } else if (char == 'C')
            {
                GameObject tube = Instantiate(Instantiate(Resources.Load("Tube")) as GameObject);
                tube.transform.position = new Vector3(
                    x * tube.transform.localScale.x + xOffset,
                    y * tube.transform.localScale.y + yOffset,
                    0
                    );
            } else if (char == 'P')
            {
                GameObject pill = Instantiate(Instantiate(Resources.Load("Pill")) as GameObject);
                pill.transform.position = new Vector3(
                    x * pill.transform.localScale.x + xOffset,
                    y * pill.transform.localScale.y + yOffset,
                    0
                    );
            }
        }

    }
}
