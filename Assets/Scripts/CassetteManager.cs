﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CassetteManager : MonoBehaviour
{
    // Start is called before the first frame update


    public WeaponsController[] Cassettes;


    public Cassette[] CasseteCash;


    private void Start()
    {
        for (int i = 0; i < Cassettes.Length; i++)
        {
            var cassette = Cassettes[i];
            CasseteCash[i].SetItem(cassette);
        }
    }
    


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") || Input.GetKey(KeyCode.Alpha1)) Trigger(Cassettes[0]);
        if (Input.GetButton("Fire2") || Input.GetKey(KeyCode.Alpha2)) Trigger(Cassettes[1]);
        if (Input.GetButton("Fire3") || Input.GetKey(KeyCode.Alpha3)) Trigger(Cassettes[2]);
    }

    void Trigger(WeaponsController controller)
    {
        if (controller)
        {
            controller.Activate();
        }
    }
}