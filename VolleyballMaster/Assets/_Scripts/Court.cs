﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VolleyballMaster.DS;

public class Court : Cola
{
    private string nombre;
    private bool ocupado;   // no creo que se nesesite

    public Court(string nombre)
    {
        this.nombre = nombre;
    }

    public Court()
    {
    }
}
