using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

[RequireComponent(typeof(Text))]
public class TextChanger : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private string _textToReplace;
    [SerializeField] private string _textToAdd;
    [SerializeField] private string _textToHack;

    private Text _text;

    private void Start()
    {
        _text = GetComponent<Text>();

        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(_textToReplace,_duration));

        sequence.Append(_text.DOText(_textToAdd, _duration).SetRelative());

        sequence.Append(_text.DOText(_textToHack, _duration, true,ScrambleMode.All));
    }
}
