using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewStorySceneVisual",menuName = "DataVisual/ New Story Scene Visual")]
[System.Serializable]
public class StorySceneVisual : GameSceneVisual //Cambiar al minuto 11:24 a GameSceneVisual
{
    public List<Sentence> sentences;
    public Sprite background;
    public GameSceneVisual nextScene; //Cambiar al minuto 11:24 a GameSceneVisual

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
