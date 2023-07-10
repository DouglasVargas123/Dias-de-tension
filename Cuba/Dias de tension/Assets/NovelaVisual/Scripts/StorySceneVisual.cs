using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewStorySceneVisual",menuName = "DataVisual/ New Story Scene Visual")]
[System.Serializable]
public class StorySceneVisual : ScriptableObject
{
    public List<Sentence> sentences;
    public Sprite background;
    public StorySceneVisual nextScene;

    [System.Serializable]

    public struct Sentence
    {
        public string text;
        public Speakers speaker;
    }
}

public class GameSceneVisual: ScriptableObject
{

}
