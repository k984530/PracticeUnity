using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class goTestScene : MonoBehaviour
{

    public void OnbuttonClick() {
        SceneManager.LoadScene("PracticeScene_changeScene");
    }
}
