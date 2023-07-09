using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController2 : MonoBehaviour
{
    public StoryScene2 currentScene;
    public BottomBarController2 bottomBar;
    public Phone phone;
    public bool inCall = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && phone.inPhone)
        {
            if (bottomBar.IsCompleted())
            {
                bottomBar.PlayNextSentence();
            }
        }
    }

}
