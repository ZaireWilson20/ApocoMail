using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySpawn : MonoBehaviour
{
    [SerializeField] private Image[] _inventoryObjects = null;
    [SerializeField] private int _testIndex = -1;
    //[SerializeField] private Canvas _canvas;
    private Transform _spawnPoint = null;
    private Image _spawnedObject = null;
    [HideInInspector] public int index = 0;
    
    void Start()
    {
        _spawnPoint = GetComponent<Transform>();
        for (int i=0; i < _inventoryObjects.Length; i++){
            _inventoryObjects[i].gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_testIndex > index){
            //_spawnedObject = Instantiate(_inventoryObjects[index], _spawnPoint.transform);
            //_spawnedObject.rectTransform.anchoredPosition = Vector3.zero;
            if(index -1 >= 0){
                _inventoryObjects[index - 1].gameObject.SetActive(false);
            }
            _inventoryObjects[index].gameObject.SetActive(true);
            index = _testIndex;
        }
    }
}
