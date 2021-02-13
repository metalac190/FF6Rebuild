using System.Collections;
using System;

public interface IState
{
    // automatically gets called in the State machine. Allows you to delay flow if desired
    void Enter();
    // allows simulation of Update() method without a MonoBehaviour attached
    void Update();
    // simulation of FixedUpdate() method
    void FixedUpdate();
    // automatically gets called in the State machine. Allows you to delay flow if desired
    void Exit();
}