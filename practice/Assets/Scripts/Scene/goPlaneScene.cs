using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class goPlaneScene : MonoBehaviour
{
    public void Onclickbtn() {
        SceneManager.LoadScene("SingleTon");
    }
}
