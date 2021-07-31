using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryTest : MonoBehaviour
{
    Dictionary<string, string> dic = new Dictionary<string, string>()
    {
        {"이름", "조상철" } , {"취미", "축구"}
    };
    void Start()
    {
        foreach (KeyValuePair<string, string> tmp in dic)
            Debug.Log(tmp);
    }

}
