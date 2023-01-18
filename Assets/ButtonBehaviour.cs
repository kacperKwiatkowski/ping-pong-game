using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
    public void MoveToScene(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }
}