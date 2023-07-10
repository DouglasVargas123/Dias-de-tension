using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController2 : MonoBehaviour
{
    public StoryScene2 currentScene;
    public BottomBarController2 bottomBar;
    public Phone phone;
    public bool inCall = false;

    private State state = State.IDLE;

    private enum State
    {
        IDLE, ANIMATE
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && phone.inPhone)
        {
            if (state == State.IDLE && bottomBar.IsCompleted())
            {
                if (bottomBar.IsLastSentense())
                {
                    PlayScene(currentScene.nextScene2);
                }
                else
                {
                    bottomBar.PlayNextSentence();
                }

            }
        }
    }

    private void PlayScene(StoryScene2 scene2)
    {
        StartCoroutine(SwitchScene(scene2));
    }

    private IEnumerator SwitchScene(StoryScene2 scene2)
    {
        state = State.ANIMATE;
        currentScene = scene2;
        yield return new WaitForSeconds(1f);
        bottomBar.PlayScene(scene2);
        state = State.IDLE;
    }


}
