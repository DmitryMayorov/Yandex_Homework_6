using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ModelVariants : MonoBehaviour
{
    public static GameObject _currenSelected;

    [SerializeField] private GameObject[] _models; 

    [SerializeField] private TMP_Dropdown _dropdown;

    [SerializeField] MaterialManager _materialManager;

    private void Start()
    {
        _currenSelected = _models[0];

        List<TMP_Dropdown.OptionData> _optionDataList = new List<TMP_Dropdown.OptionData>();
        foreach (var item in _models)
        {
            TMP_Dropdown.OptionData data = new TMP_Dropdown.OptionData();
            data.text = item.name;
            _optionDataList.Add(data);
        }
        _dropdown.options = _optionDataList;

        _dropdown.onValueChanged.AddListener(Select);

        _materialManager.SetMaterial(_materialManager._material);
    }

    public void Select(int index)
    {
        _currenSelected.SetActive(false);
        _currenSelected = _models[index];
        _currenSelected.SetActive(true);
        _materialManager.SetMaterial(_materialManager._material);
    }
}
