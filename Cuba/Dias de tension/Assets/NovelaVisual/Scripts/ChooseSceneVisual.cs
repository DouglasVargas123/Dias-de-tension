using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewChooseSceneVisual", menuName = "DataVisual/New Choose Scene")]
[System.Serializable]
public class ChooseSceneVisual : GameSceneVisual
{
    public List<ChooseLabel> labels;

    [System.Serializable]
    public struct ChooseLabel
    {
        public string text;
        public StorySceneVisual nextScene;
    }
}
