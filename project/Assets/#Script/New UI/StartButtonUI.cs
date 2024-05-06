using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonUI : MonoBehaviour
{
    public void TestCall()
    {
        SceneManager.LoadScene("Main");
    }
}
