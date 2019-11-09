using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SceneSettings", menuName = "Scene/Settings")]
[System.Serializable]
public class SceneSettings : ScriptableObject
{
    [Header("Scoreboard Configuration")]
    public bool scoreLabelEnabled;
    public bool livesLabelEnabled;

    [Header("Scene Labels")]
    public bool startLabelActive;
    public bool highScoreLabelEnabled;
    public bool endLabelActive;

    [Header("Scene Buttons")]
    public bool startButtonActive;
    public bool restartButtonActive;

    [Header("Scene Configuration")]
    public SoundClip activeSoundClip;
    public Scene scene;
}