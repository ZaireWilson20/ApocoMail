using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MidGameMenu : MonoBehaviour
{
    [SerializeField] private GameObject _newMenu;
    [SerializeField] private GameObject _oldMenu;

    public void OnClick()
    {
        _newMenu.SetActive(true);
        _oldMenu.SetActive(false);
    }

    public void OnClickQuit(){
        //print("quitNow");
        Application.Quit();
    }

}
