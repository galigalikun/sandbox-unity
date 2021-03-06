﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UniRx;

[RequireComponent(typeof(UnityEngine.UI.ScrollRect))]
public class UIScrollView : BaseUI<UnityEngine.UI.ScrollRect>
{

    // Use this for initialization
    void Start()
    {
        ui.Value.onValueChanged.AsObservable()
        .Subscribe(abcdef =>
        {
            Debug.Log($"scroll?? {abcdef}");
        })
        .AddTo(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
