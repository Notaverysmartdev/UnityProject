﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DELETEPRATIcals : MonoBehaviour
{
    public float destorytimer = 0.2f;

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "gunhiteffect(Clone)")
        {
            Destroy(gameObject,destorytimer);

        }
        if (gameObject.name == "ai death(Clone)")
        {
            Destroy(gameObject, destorytimer);

        }
        if (gameObject.CompareTag("afterburntdamage"))
        {
            Destroy(gameObject, destorytimer);
        }

        if (gameObject.name == "explosion(Clone)")
        {
            Destroy(gameObject, destorytimer);
        }
        if (gameObject.name == "explosiondamage(Clone)")
        {
            Destroy(gameObject, destorytimer);
        }
        if (gameObject.name == "KatanaEffect(Clone)")
        {
            Destroy(gameObject, destorytimer);
        }
        if(gameObject.name == "TankDamage(Clone)")
        {
            Destroy(gameObject, destorytimer);
        }
        if (gameObject.name == "barreldamage(Clone)")
        {
            Destroy(gameObject, destorytimer);
        }
        if (gameObject.name == "barrelexplosion(Clone)")
        {
            Destroy(gameObject, destorytimer);
        }
    }
}
