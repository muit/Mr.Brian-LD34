﻿using UnityEngine;
using System.Collections.Generic;

public class Delay
{
    private int length;
    private float endTime;
    private bool started;

    public Delay(int length, bool start = true) {
        this.length = length;
        if (start) {
            Start();
        } else {
            started = false;
        }
    }

    public bool Over() {
        if (!started)
            return false;

        return Time.time*1000 >= endTime;
    }

    public void Start() {
        started = true;
        endTime = length + Time.time*1000;
    }

    public void Reset() {
        started = false;
    }

    public bool Active() {
        return started;
    }

    public void End() {
        started = true;
        endTime = 0;
    }
}