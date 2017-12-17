﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using miniPokemon;

public class LanceFlamme : Attack
{
    public GameObject animator;

    public LanceFlamme():base(0.7f)
    {
    }


    public override void Animation(int attacker, int defender)
    {
        animator.SetActive(true);
    }
}
