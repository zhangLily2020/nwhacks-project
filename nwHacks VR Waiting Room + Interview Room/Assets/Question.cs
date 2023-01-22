using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "AAA/Questions", order = 1)]
public class Question : ScriptableObject
{
    public string prompt;
    public string[] keywords;

}
