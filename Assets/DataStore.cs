using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStore : MonoBehaviour {

    public static DataStore Instance { get; private set; }
    public string playerName;


    public string PlayerName {
        get => playerName;
        set => playerName = value;
    }

    private void Awake() {
        if (Instance != null) return;
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [Serializable]
    public class Data {

        public int score;

        public int Score {
            get => score;
            set => score = value;
        }

    }

}