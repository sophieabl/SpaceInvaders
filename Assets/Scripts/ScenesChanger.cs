using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesChanger : MonoBehaviour
{
    public void LoadLevelScene()
    {
        // Changes Scene when restarting the Game 
        SceneManager.LoadScene("SpaceInvaders");
    
    }
    

}
