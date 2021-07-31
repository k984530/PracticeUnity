﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public delegate void PlayerEventHandler();
    public enum EventType { 
        Touch,
        Die,
        ExitTouch
    }

    public static Dictionary<EventType, PlayerEventHandler> _delegateDic;
    void Awake() {
        if (instance == null) instance = this;

        _delegateDic = new Dictionary<EventType, PlayerEventHandler>();
    }

    public void AddListener(EventType EventType, PlayerEventHandler delegateFunc) {
        if (_delegateDic.ContainsKey(EventType) == false){
            _delegateDic.Add(EventType, delegateFunc);
        }

        _delegateDic[EventType] += delegateFunc;
    }

    public void NotifyEvent(EventType EventType) {
        if (_delegateDic.ContainsKey(EventType) == false) { return; }
        foreach (PlayerEventHandler delegateFunc in _delegateDic[EventType].GetInvocationList()) {
            delegateFunc();
        }
    }
}
