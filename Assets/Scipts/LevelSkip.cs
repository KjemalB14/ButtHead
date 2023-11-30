using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelSkip : MonoBehaviour
{
    public void LoadLevelTwo()
    {
        SceneManager.LoadScene(2);
    }
}
