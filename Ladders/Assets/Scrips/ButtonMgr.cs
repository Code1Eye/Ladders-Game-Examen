using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonMgr : MonoBehaviour {


    void Start()
    {
       
    }

    public void LoadBtn(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    	void Awake(){
		DontDestroyOnLoad(this);
        
	}
}
