using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CircleText : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _textMeshPro;

    private void ChangeNumber()
    {
        _textMeshPro.text = GetComponent<CircleInfo>().CircleIndex.ToString();
    }

    private void Awake()
    {
        EventManager.Instance.OnCirclesSpawned += ChangeNumber;
    }
    private void OnDisable()
    {
        EventManager.Instance.OnCirclesSpawned -= ChangeNumber;
    }
}
