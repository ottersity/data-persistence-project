using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour {

    public TMP_InputField playerNameInput;
    
    public void OnClick() {
        DataStore.Instance.playerName = playerNameInput.text;
        SceneManager.LoadScene("main");
    }

}