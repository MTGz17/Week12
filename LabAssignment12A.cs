using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabAssignment12A : MonoBehaviour
{
    int count;

    List<string> _names = new List<string>();

    string[] _firstNames = {"Abraham", "Dan", "Natasha", "Penny", "Wyatt", "Jane", "May", "Nathan", "Bailey", "Ashley", "Alexa", "Carmen", "Matt", "Joshua", "Jesus", "Max", "Maria", "Sophia", "Sarah", "Nicole"};
    string[] _lastNames = {"A.", "B.", "C.", "D.", "E.", "F.", "G.", "H.", "I.", "J.", "K.", "L.", "M."};

    // Start is called before the first frame update
    void Start()
    {
        count = Random.Range(3,15);
        for (int i = 0; i < count; i++)
            {
                _names.Add(_firstNames[Random.Range(0,21)] + " " + _lastNames[Random.Range(0,14)]);
            }

        Debug.Log("Initial login queue created. There are "+ count +" players in the queue");
        
        StartCoroutine(Login());
        StartCoroutine(NameAdder());
    }

    public IEnumerator Login()
    {
        for(;;)
        {
        yield return new WaitForSeconds(Random.Range(1,6));
        Debug.Log(_names[0]+ " is now inside the game.");

        _names.RemoveAt(0);
        }
    }

    public IEnumerator NameAdder()
    {
        for(;;)
        {
        yield return new WaitForSeconds(Random.Range(1,6));

        _names.Add(_firstNames[Random.Range(0,21)] + " " + _lastNames[Random.Range(0,14)]);

        Debug.Log(_names[_names.Count - 1]+ " is trying to login and added to the login queue.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}