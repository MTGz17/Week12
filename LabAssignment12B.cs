using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabAssignment12B : MonoBehaviour
{
    int count;

    List<string> _names = new List<string>();

    string[] _firstNames = {"Abraham", "Dan", "Natasha", "Penny", "Wyatt", "Jane", "May", "Nathan", "Bailey", "Ashley", "Alexa", "Carmen", "Matt", "Joshua", "Jesus", "Max", "Maria", "Sophia", "Sarah", "Nicole"};

    HashSet<string> uniqueNames = new HashSet<string>{"Abraham", "Dan", "Natasha", "Penny", "Wyatt", "Jane", "May", "Nathan", "Bailey", "Ashley", "Alexa", "Carmen", "Matt", "Joshua", "Jesus", "Max", "Maria", "Sophia", "Sarah", "Nicole"};

    // Start is called before the first frame update
    void Start()
    {
        count = Random.Range(20,31);
        for (int i = 0; i < count; i++)
            {
                _names.Add(_firstNames[Random.Range(0,20)]);
            }
        
        HashSet<string> commonChars = new HashSet<string>(uniqueNames);
        commonChars.IntersectWith(_names);

        foreach (var c in commonChars)
        {
            Debug.Log(c);
        }
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
