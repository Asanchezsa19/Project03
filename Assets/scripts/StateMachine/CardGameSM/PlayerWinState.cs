using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class PlayerWinState : CardGameState
{
    
    public override void Enter()
    {
        SceneManager.LoadScene("Win");
    }
}
