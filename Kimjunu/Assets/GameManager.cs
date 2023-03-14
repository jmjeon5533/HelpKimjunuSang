using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public static GameManager instance = new GameManager();
    public string[,] dialog;
    [SerializeField] TextAsset StudentList; //csv
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        string[] lines = StudentList.text.Split('\n');
        for (int i = 0; i < lines.Length; i++)
        {
            string[] columm = lines[i].Split('\t');
            for (int j = 0; j < columm.Length; i++)
            {
                string text = columm[j];
                dialog[i, j] = text;

            }
        }
        for (int i = 0; i < dialog.GetLength(0); i++)
        {
            for (int j = 0; j < dialog.GetLength(1); j++)
            {
                print(dialog[i,j]);
            }
        }
    }

}
