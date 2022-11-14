using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwitchToGame : MonoBehaviour
{
    public Button button;
    
    void Start()
    {
        button.onClick.AddListener(() => { SceneManager.LoadScene("Game", LoadSceneMode.Single); });
    }
}
