using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class EnemyWinState : CardGameState
{
    public override void Enter()
    {
        SceneManager.LoadScene("Lose");
    }
}
