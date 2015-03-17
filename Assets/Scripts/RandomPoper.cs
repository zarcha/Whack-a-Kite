using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RandomPoper : MonoBehaviour {

	public GameObject[] kites;
	public int randNum;
	public float popTimer;
	public bool pause = false;
	public int score;
	public float timer = 60.0f;
	public int level = 0;
	public bool timed = false;
	public float stopped = 0.0f;
	
	public GameObject scoreTxt;
	public GameObject timerTxt;
	public GameObject highScoreTxt;
	public GameObject Cam;
	
	public int highScore;
	public int highScoreSave;
	
	public GameObject pauseM;
	
	public int timesRan = 0;

	// Use this for initialization
	void Start () {
		pause = true;
		for(int i = 0; i < kites.Length; i++)
		{
			kites[i].SetActive(false);
		}

		pause = false;
		
		switch(level)
		{
			case 1:
				highScore = PlayerPrefs.GetInt("highScore1");
				break;
			case 2:
				highScore = PlayerPrefs.GetInt("highScore2");
				break;
			case 3:
				highScore = PlayerPrefs.GetInt("highScore3");
				break;
			case 4:
				highScore = PlayerPrefs.GetInt("highScore4");
				break;
			default:
				Debug.Log("No high score saved");
				break;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(!pause)
		{
			popTimer += Time.deltaTime*level;
			if(timed)
			{
				timer -= Time.deltaTime;
			}

			if(timer <= 0)
			{
				timer = 0;
				popTimer = 0;
				for(int i = 0; i < kites.Length; i++)
				{
					kites[i].SetActive(false);
				}
				//kites[0].transform.parent.gameObject.SetActive(false);
				//Cam.GetComponent<GrayscaleEffect>().enabled = true;
				stopped += Time.deltaTime;
				if(stopped >= 2){
					pause = true;
					stopped = 0;
				}
			}

			if(popTimer >= 1)
			{
				int a = 0;
				timesRan = 0;
				
				while(a == 0){
					randNum = Random.Range(0, kites.Length-1);

					if(!kites[randNum].activeInHierarchy)
					{
						kites[randNum].SetActive(true);
						kites[randNum].GetComponent<popHit>().disTime = 0;
						a = 1;
					}
					
					timesRan++;
					if(timesRan > 30)
					{
						for(int i = 0; i < kites.Length; i++)
						{
							if(!kites[i].activeInHierarchy)
							{
								kites[i].SetActive(true);
								kites[i].GetComponent<popHit>().disTime = 0;
								break;
							}
						}
						
						a = 1;
					}
				}

				popTimer = 0;
			}

			scoreTxt.GetComponent<TextMesh>().text = "Score: " + score.ToString();
			if(timed)
			{
				timerTxt.GetComponent<TextMesh>().text = "Time: " + timer.ToString("F");
				if(timer <= 0)
				{
					if(score > highScore){
						switch(level)
						{
							case 1:
								PlayerPrefs.SetInt("highScore1", score);
								break;
							case 2:
								PlayerPrefs.SetInt("highScore2", score);
								break;
							case 3:
								PlayerPrefs.SetInt("highScore3", score);
								break;
							case 4:
								PlayerPrefs.SetInt("highScore4", score);
								break;
							default:
								Debug.Log("No high score saved");
								break;
						}
						highScore = score;
					}
				}
			}
		}
		else
		{
			//Cam.GetComponent<GrayscaleEffect>().enabled = true;
			if(!pauseM.activeInHierarchy)
			{
				pauseM.SetActive(true);
				highScoreTxt.GetComponent<Text>().text = "High Score: " + highScore.ToString();
			}
		}
	}
}
