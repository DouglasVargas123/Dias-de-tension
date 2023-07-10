using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BottomBarController2 : MonoBehaviour
{
    public TextMeshProUGUI barText;
    public TextMeshProUGUI personNameText;
    public Image Foto;

    private int sentenceIndex = -1;
    public StoryScene2 currentScene;
    private State state = State.COMPLETED;

    public GameObject backGround;

    private enum State
    {
        PLAYING, COMPLETED
    }



    public void PlayScene(StoryScene2 scene2)
    {
        currentScene = scene2;
        sentenceIndex = -1;
        backGround.SetActive(true);
        PlayNextSentence();
    }

    public void PlayNextSentence()
    {
        StartCoroutine(TypeText(currentScene.sentences[++sentenceIndex].text));
        personNameText.text = currentScene.sentences[sentenceIndex].contactos.nombre;
        personNameText.color = currentScene.sentences[sentenceIndex].contactos.textColor;
        Foto.sprite = currentScene.sentences[sentenceIndex].contactos.Foto;
    }

    public bool IsCompleted()
    {
        return state == State.COMPLETED;
    }

    public bool IsLastSentense()
    {
        return sentenceIndex + 1 == currentScene.sentences.Count;
    }

    private IEnumerator TypeText(string text)
    {
        barText.text = "";
        state = State.PLAYING;
        int wordIndex = 0;

        while (state != State.COMPLETED)
        {
            barText.text += text[wordIndex];
            yield return new WaitForSeconds(0.05f);
            if (++wordIndex == text.Length)
            {
                state = State.COMPLETED;
                break;
            }
        }
    }
}
