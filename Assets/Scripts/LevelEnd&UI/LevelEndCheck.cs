using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
using UnityEngine.UI;
public class LevelEndCheck : MonoBehaviour
{
    [SerializeField] private GameObject levelEndObject;

    public static LevelEndCheck Instance;
    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        levelEndObject.GetComponent<Button>().onClick.AddListener(() => RestartLevel());

        levelEndObject.SetActive(false);
    }
    public void TriggerLevelEnd()
    {
        levelEndObject.SetActive(true);
    }

    private void RestartLevel()
    {
#pragma warning disable CS0618
        Application.LoadLevel(Application.loadedLevel);
#pragma warning restore CS0618
    }
}
