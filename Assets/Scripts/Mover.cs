using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Transform _target;

    private void Start()
    {
        transform.DOMove(_target.position, _duration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
