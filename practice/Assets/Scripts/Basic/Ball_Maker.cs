using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Maker : MonoBehaviour
{
    public GameObject ball;
    public Transform shootPos;
    bool shootOK = true;
    void Update()
    {
        if (shootOK)
            if (Input.GetKey(KeyCode.Space))
                StartCoroutine("ShootBall");
    }
    IEnumerator ShootBall() {
        shootOK = false;
        GameObject tmp = Instantiate(ball, shootPos.position, shootPos.rotation);
        Destroy(tmp, 0.5f);
        yield return new WaitForSeconds(0.5f);
        shootOK = true;

    }
}
