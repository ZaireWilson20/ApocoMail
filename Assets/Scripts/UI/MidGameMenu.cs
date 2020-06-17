using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidGameMenu : MonoBehaviour
{
    [SerializeField] private GameObject _menu;
    [SerializeField] private GameObject _button;

    public void OnClick()
    {
        _menu.SetActive(true);
        _button.SetActive(false);
    }

    public void OnClickBack()
    {
        _menu.SetActive(false);
        _button.SetActive(true);
    }
}
