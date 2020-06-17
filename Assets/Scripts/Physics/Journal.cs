using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Journal : MonoBehaviour
{
    [SerializeField] private string[] _journalWriting = null;
    private Text _text = null;
    [HideInInspector] public int index = 0;


    void Awake()
    {
        _text = GetComponent<Text>();
    }
    void Update()
    {
        if (index <= _journalWriting.Length){
            _text.text = _journalWriting[index];
        }
    }
}
