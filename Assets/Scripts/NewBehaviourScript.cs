﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Debug.Log($"sample2:{DataStore.Instance.Test}");

        var list = new List<string> {
            "test1",
            "test2",
        };

        list.RemoveAt(1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
