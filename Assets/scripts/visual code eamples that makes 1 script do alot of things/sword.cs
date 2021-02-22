﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : baseitem
{
    public Gun gun;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            ShootGun();
        }
    }

    public override void ShootGun()
    {
        base.ShootGun();

        Debug.Log("shooting normal bullet...");
    }
}
