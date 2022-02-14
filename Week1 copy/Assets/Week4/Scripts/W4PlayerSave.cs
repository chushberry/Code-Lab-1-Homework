using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class W4PlayerSave : MonoBehaviour
{
    public string filename;

    const char delimiter - '|';
    // Start is called before the first frame update
    void Start()
    {
        StreamReader reader = new StreamReader(filename);
        string newPos = reader.ReadLine();
        reader.Close();
        Debug.Log(newPos);

        string[] pos = newPos.Split(new char[] { delimiter });
        transform.position = new Vector3(float.Parse(pos[0]), float.Parse(pos[1]), float.Parse(pos[2]));

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // saves the player's position
            StreamWriter writer = new StreamWriter(filename);
            writer.Write("" +
                transform.position.x + delimiter +
                transform.position.y + delimiter +
                transform.position.z);
            writer.Close();
        }
    }
}
