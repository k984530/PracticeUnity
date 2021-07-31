using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class DictionaryTest2 : MonoBehaviour
{
    Dictionary<string, string> dic = new Dictionary<string, string>()
    {
        {"이름", "조상철" } , {"취미", "축구"}
    };
    void Start()
    {
        dic["이름"] += " 조단비";
        dic["이름"] += " 조은비";

        StringBuilder str = new StringBuilder();

        foreach (var tmp in dic)
            str.Append("Key = " + tmp.Key + "Value = " + tmp.Value + "\n");
    Debug.Log(str.ToString());
    }

}
