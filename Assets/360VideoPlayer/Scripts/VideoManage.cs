using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoManage : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void GoToScene(string SceneName)
	{
		SceneManager.LoadScene (SceneName);
	}



	public void QuitApplication()
	{
		Application.Quit();
	}

}
