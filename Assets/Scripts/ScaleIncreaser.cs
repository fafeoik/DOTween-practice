using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ScaleIncreaser : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private float _targetSize;

    private void Start()
    {
        transform.DOScale(_targetSize, _duration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
