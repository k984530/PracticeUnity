using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class goTitleScene : MonoBehaviour
{
    //버튼 클릭 시 처리될 함수
    public void OnButtonClick() {
        SceneManager.LoadScene("TitleScene");
    }
}
