using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Rotater : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Vector3 _rotateTarget;

    private void Start()
    {
        transform.DORotate(_rotateTarget, _duration).SetLoops(-1,LoopType.Restart).SetRelative().SetEase(Ease.Linear);
    }
}
