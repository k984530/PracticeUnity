using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TramsformEx : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 첫 번째 방법
        transform.position = new Vector3(0, 0, 1f);
        // 두 번째 방법
        Vector3 pos = transform.position;
        pos.x = 1;
        pos.y = 1;
        pos.z = 1;
        transform.position = pos;
        // 세 번째 방법
        transform.Translate(Vector3.forward);
        // 세 번째 방법 (2)
        transform.Translate(new Vector3(0,0,1f));
        // 네 번째 방법
        transform.position += new Vector3(0,0,1f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
