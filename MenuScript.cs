using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public GameObject menuScreen, levelScreen, puzzleScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayBtn()
    {
        menuScreen.SetActive(false);
        puzzleScreen.SetActive(true);
    }
    public void levelBtn()
    {
        menuScreen.SetActive(false);
        levelScreen.SetActive(true);
    }
}
