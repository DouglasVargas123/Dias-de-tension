using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NewSpeaker", menuName = "Data/New Speaker")]
[System.Serializable]
public class Speakers : ScriptableObject
{
    public string speakerName;
    public Color textColor;
    public Image Imagen;
}
