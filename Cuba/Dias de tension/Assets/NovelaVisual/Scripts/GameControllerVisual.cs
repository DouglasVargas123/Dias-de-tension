using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerVisual : MonoBehaviour
{
    public StorySceneVisual currentScene;
    public BottomBarControllerVisual bottomBar;
    public GameObject Transicion;

    private State state = State.IDLE;

    private enum State
    {
        IDLE,ANIMATE
    }

    private void Start()
    {
        bottomBar.PlayScene(currentScene);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (state == State.IDLE && bottomBar.IsCompleted())
            {
                if (bottomBar.IsLastSentence())
                {
                    PlayScene(currentScene.nextScene);
                }
                else
                {
                    bottomBar.PlayNextSentence();
                    StartCoroutine(TRANSICION());
                }

            }
        }
    }

    private void PlayScene(StorySceneVisual scene)
    {
        StartCoroutine(SwitchScene(scene));
    }

    IEnumerator TRANSICION()
    {
        Transicion.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Transicion.SetActive(false);
        yield return null;
    }

    private IEnumerator SwitchScene(StorySceneVisual scene)
    {
        state = State.ANIMATE;
        currentScene = scene;
        Transicion.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Transicion.SetActive(false);
        bottomBar.PlayScene(scene);
        state = State.IDLE;
    }
}
