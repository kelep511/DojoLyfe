﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlgorithmStuff : MonoBehaviour {

    public int AlgorithmPlusPlus;

    public int Time;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D()
    {
        PlayerStats.ChangeAlgorithms(AlgorithmPlusPlus);
        PlayerStats.ChangeTime(Time);
    }
}