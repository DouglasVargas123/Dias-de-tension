using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewStoryScene2", menuName = "Data/New Story Scene 2")]
[System.Serializable]
public class StoryScene2 : ScriptableObject
{

    public List<Sentence> sentences;
    public Sprite background;
    public StoryScene2 nextScene2;

    [System.Serializable]
    public struct Sentence
    {
        public string text;
        public Contactos contactos;
    }
}
