using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewChoosenScene", menuName = "Data/New Choose Scene")]
public class ChooseScene : ScriptableObject
{
    public List<ChooseLabel> labels;

    [System.Serializable]
    public struct ChooseLabel
    {
        public string text;
        public StoryScene2 nextScene;
    }
}
