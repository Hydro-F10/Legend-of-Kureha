﻿using UnityEngine;
using System.Collections;

public class NormalEnemy : EnemyMove
{

    // Use this for initialization
    public override void Start () {
        
    }

    // Update is called once per frame
    public override void Update () {
        EnemyCharge(3.0f);
	}
}
