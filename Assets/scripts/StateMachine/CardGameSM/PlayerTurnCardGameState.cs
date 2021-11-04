using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTurnCardGameState : CardGameState
{
    [SerializeField] Text _playerTurnTextUI = null;

    int _playerTurnCount = 0;

    public override void Enter()
    {
        Debug.Log("Player Turn: ...Entering");
        _playerTurnTextUI.gameObject.SetActive(true);

        _playerTurnCount++;
        _playerTurnTextUI.text = "Player Turn: " + _playerTurnCount.ToString();
        // hook into events
        StateMachine.Input.PressedConfirm += OnPressedConfirm;
        StateMachine.Input.PressedWin += OnPressedWin;
        StateMachine.Input.PressedLose += OnPressedLose;
    }

    public override void Exit()
    {
        _playerTurnTextUI.gameObject.SetActive(false);
        // unhook from events
        StateMachine.Input.PressedConfirm -= OnPressedConfirm;

        Debug.Log("PlayerTurn: Exiting...");
    }

    void OnPressedConfirm()
    {
        StateMachine.ChangeState<EnemyTurnCardGameState>();
    }
    void OnPressedWin()
    {
        StateMachine.ChangeState<PlayerWinState>();
    }
    void OnPressedLose()
    {
        StateMachine.ChangeState<EnemyWinState>();
    }
}
