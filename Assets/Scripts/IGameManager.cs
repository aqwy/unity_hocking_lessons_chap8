using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IGameManager
{
    managerStatus status { get; }
    void Startup();

}

