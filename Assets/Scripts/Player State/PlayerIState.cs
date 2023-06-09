using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface PlayerIState<T>
{
    void OnStart(T t);
    void OnExecute(T t);
    void OnExit(T t);
}
