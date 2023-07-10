using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerVisual : MonoBehaviour
{
    public GameSceneVisual currentScene;
    public BottomBarControllerVisual bottomBar;
    public GameObject Transicion;
    public ChooseControllerVisual chooseController;

    private State state = State.IDLE;

    private enum State
    {
        IDLE,ANIMATE,CHOOSE
    }

    private void Start()
    {
        if(currentScene is StorySceneVisual)
        {
            StorySceneVisual storyScene = currentScene as StorySceneVisual;
            bottomBar.PlayScene(storyScene);

        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (state == State.IDLE && bottomBar.IsCompleted())
            {
                if (bottomBar.IsLastSentence())
                {
                    PlayScene((currentScene as StorySceneVisual).nextScene);
                }
                else
                {
                    bottomBar.PlayNextSentence();
                    StartCoroutine(TRANSICION());
                }

            }
        }
    }

    public void PlayScene(GameSceneVisual scene)
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

    private IEnumerator SwitchScene(GameSceneVisual scene)
    {
        state = State.ANIMATE;
        currentScene = scene;
        Transicion.SetActive(true);
        if(scene is StorySceneVisual)
        {
            StorySceneVisual storyScene = scene as StorySceneVisual;
            yield return new WaitForSeconds(0.5f);
            Transicion.SetActive(false);
            bottomBar.PlayScene(storyScene);
            state = State.IDLE;
        }
        else if(scene is ChooseSceneVisual)
        {
            Transicion.SetActive(false);
            state = State.CHOOSE;
            chooseController.SetupChoose(scene as ChooseSceneVisual);
        }
    }
}
