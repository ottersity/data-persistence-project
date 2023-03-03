using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class LoadHighScore : MonoBehaviour {

    [SerializeField] private TextMeshProUGUI highScoreText;

    void Start() {
        highScoreText = GetComponent<TextMeshProUGUI>();
        var path = $"{Application.persistentDataPath}/score.json";
        if (!File.Exists(path)) return;
        var json = File.ReadAllText(path);
        highScoreText.text = $"Best Score: {Convert.ToString(JsonUtility.FromJson<DataStore.Data>(json).Score)}";
    }

}