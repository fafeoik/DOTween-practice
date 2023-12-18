using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Color _targetColor;
    

    private void Start()
    {
        Material material = GetComponent<Renderer>().material;

        material.DOColor(_targetColor, _duration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
