using System;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
	public GameObject pausePanel;
	public GameObject stopbutton;
	private bool isPaused = false;

	public void OpenPause()
    {
		Time.timeScale = 0.0f;
		stopbutton.SetActive(false);
		pausePanel.SetActive(true);
	}

    public void ClosePause()
    {
		Time.timeScale = 1.0f;
		stopbutton.SetActive(true);
		pausePanel.SetActive(false);
	}

	void Update()
	{
		if (stopbutton.active)
		{
			TogglePause();
		}
	}

	void TogglePause()
	{
		isPaused = !isPaused;

		if (isPaused)
		{
			OpenPause();
		}
		else
		{
			ClosePause();
		}
	}
}