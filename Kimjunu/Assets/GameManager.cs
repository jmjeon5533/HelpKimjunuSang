using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = new GameManager();

    [SerializeField] TextAsset StudentList; //csv
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        string[] lines = StudentList.text.Split('\n');
        for(int i = 0; i < lines.Length ; i++)
         {
            string[] columm = lines[i].Split('\t');
        }
    }

}
