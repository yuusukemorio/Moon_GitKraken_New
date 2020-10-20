using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EDRoll_Title : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("Title2");
        clear.GameClear = "yes";

    }
}
