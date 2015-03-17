using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	public GameObject startM;
	public GameObject typeM;
	public GameObject levelsM;
	public GameObject gameM;
	public GameObject cam;
	public GameObject pauseM;
	public GameObject gameBackM;
	public GameObject menuM;
	public GameObject kites;

	void Start () {
		startM.SetActive(true);
		typeM.SetActive(false);
		levelsM.SetActive(false);
		gameM.SetActive(false);
	}
	
	public void ButStart()
	{
		GetComponent<AudioSource>().Play();
		typeM.SetActive(true);
		startM.SetActive(false);
	}
	
	public void ButTimed()
	{
		GetComponent<AudioSource>().Play();
		kites.GetComponent<RandomPoper>().timed = true;
		levelsM.SetActive(true);
		typeM.SetActive(false);
	}
	
	public void ButEndless()
	{
		GetComponent<AudioSource>().Play();
		kites.GetComponent<RandomPoper>().timed = false;
		levelsM.SetActive(true);
		typeM.SetActive(false);
	}
	
	public void ButEasy()
	{
		GetComponent<AudioSource>().Play();
		kites.GetComponent<RandomPoper>().level = 1;
		kites.GetComponent<RandomPoper>().timer = 60;
		kites.GetComponent<RandomPoper>().popTimer = 0;
		gameM.SetActive(true);
		levelsM.SetActive(false);	
		gameBackM.SetActive(true);
		menuM.SetActive(false);
	}
	
	public void ButMedium()
	{
		GetComponent<AudioSource>().Play();
		kites.GetComponent<RandomPoper>().level = 2;
		kites.GetComponent<RandomPoper>().timer = 60;
		kites.GetComponent<RandomPoper>().popTimer = 0;
		gameM.SetActive(true);
		levelsM.SetActive(false);
		gameBackM.SetActive(true);
		menuM.SetActive(false);
	}
	
	public void ButHard()
	{
		GetComponent<AudioSource>().Play();
		kites.GetComponent<RandomPoper>().level = 3;
		kites.GetComponent<RandomPoper>().timer = 60;
		kites.GetComponent<RandomPoper>().popTimer = 0;
		gameM.SetActive(true);
		levelsM.SetActive(false);
		gameBackM.SetActive(true);
		menuM.SetActive(false);
	}
	
	public void ButInsane()
	{
		GetComponent<AudioSource>().Play();
		kites.GetComponent<RandomPoper>().level = 4;
		kites.GetComponent<RandomPoper>().timer = 60;
		kites.GetComponent<RandomPoper>().popTimer = 0;
		gameM.SetActive(true);
		levelsM.SetActive(false);
		gameBackM.SetActive(true);
		menuM.SetActive(false);
	}
	
	public void ButBack()
	{
		GetComponent<AudioSource>().Play();
		levelsM.SetActive(false);
		typeM.SetActive(true);
	}
	
	public void ButRestart()
	{
		GetComponent<AudioSource>().Play();
		kites.GetComponent<RandomPoper>().timer = 60.0f;
		kites.GetComponent<RandomPoper>().score = 0;
		for(int i = 0; i < kites.GetComponent<RandomPoper>().kites.Length ; i++)
		{
			kites.GetComponent<RandomPoper>().kites[i].SetActive(false);
		}
		pauseM.SetActive(false);
		kites.GetComponent<RandomPoper>().pause = false;
	}
	
	public void ButResume()
	{
		GetComponent<AudioSource>().Play();
		pauseM.SetActive(false);
		kites.GetComponent<RandomPoper>().pause = false;
	}
	
	public void ButPause()
	{
		GetComponent<AudioSource>().Play();
		pauseM.SetActive(true);
		kites.GetComponent<RandomPoper>().pause = true;
	}
	
	public void ButExit()
	{
		GetComponent<AudioSource>().Play();
		Application.Quit();
	}
	
	public void ButStop()
	{
		GetComponent<AudioSource>().Play();
		kites.GetComponent<RandomPoper>().timer = 60.0f;
		kites.GetComponent<RandomPoper>().score = 0;
		for(int i = 0; i < kites.GetComponent<RandomPoper>().kites.Length ; i++)
		{
			kites.GetComponent<RandomPoper>().kites[i].SetActive(false);
		}
		kites.GetComponent<RandomPoper>().pause = false;
		pauseM.SetActive(false);
		gameM.SetActive(false);
		typeM.SetActive(true);
		gameBackM.SetActive(false);
		menuM.SetActive(true);
	}
}
