﻿using UnityEngine;

public class ReturnToPoolAfterTime : ReturnToPool
{
    [SerializeField] float timeToReturn = 1f;

    private float timeLeft;


    private void Update()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0)
            ObjectPoolManager.instance.ReturnToPool(this);
    }

    private void OnEnable()
    {
        timeLeft = timeToReturn;
    }
}