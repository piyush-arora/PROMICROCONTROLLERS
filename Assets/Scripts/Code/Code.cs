using UnityEngine;
using System.Collections;

public class Code : MonoBehaviour {

	private string json;
	public GameObject My_GPIO_Pin_2;
	public GameObject My_GPIO_Pin_3;
	public GameObject My_GPIO_Pin_4;
	public GameObject My_GPIO_Pin_14;
	public GameObject My_GPIO_Pin_15;
	public GameObject My_GPIO_Pin_17;
	public GameObject My_GPIO_Pin_18;
	public GameObject My_GPIO_Pin_27;
	public GameObject My_GPIO_Pin_22;
	public GameObject My_GPIO_Pin_23;
	public GameObject My_GPIO_Pin_24;
	public GameObject My_GPIO_Pin_10;
	public GameObject My_GPIO_Pin_9;
	public GameObject My_GPIO_Pin_25;
	public GameObject My_GPIO_Pin_11;
	public GameObject My_GPIO_Pin_8;
	public GameObject My_GPIO_Pin_7;
	// Use this for initialization
	void Start () 
	{
		string url = "http://hackincloud.com/my_json.json";
		WWW www = new WWW(url);
		StartCoroutine(WaitForRequest(www));

	}

	IEnumerator WaitForRequest(WWW www)
	{
		yield return www;
		// check for errors
		if (www.error == null)
		{
			json = www.text;
			My_Code code = JsonUtility.FromJson<My_Code> (json);


			// CHECK BCM NUMNERING
			if (code.NUMBERING_MODE == 1) 
			{
				// CHECK PIN 2 OUTPUT
				if (code.PIN_DETAILS.GPIO_PIN_2.PIN_MODE == 2) 
				{
					//CHECK PIN 2 HIGH
					if (code.PIN_DETAILS.GPIO_PIN_2.PIN_STATUS == 1) 
					{
						My_GPIO_Pin_2.GetComponent<Bread> ().voltage = 5;

					}

					//CHECK PIN 2 LOW
					else if (code.PIN_DETAILS.GPIO_PIN_2.PIN_STATUS == 0) 
					{
						My_GPIO_Pin_2.GetComponent<Bread> ().voltage = 0;

					} 
				}

				// CHECK PIN 3 OUTPUT
				if (code.PIN_DETAILS.GPIO_PIN_3.PIN_MODE == 2) 
				{
					//CHECK PIN 3 HIGH
					if (code.PIN_DETAILS.GPIO_PIN_3.PIN_STATUS == 1) 
					{
						My_GPIO_Pin_3.GetComponent<Bread> ().voltage = 5;

					}
					//CHECK PIN 3 LOW
					else if (code.PIN_DETAILS.GPIO_PIN_3.PIN_STATUS == 0) 
					{
						My_GPIO_Pin_3.GetComponent<Bread> ().voltage = 0;

					} 
				}

				// CHECK PIN 4 OUTPUT
				if (code.PIN_DETAILS.GPIO_PIN_4.PIN_MODE == 2) 
				{
					//CHECK PIN 4 HIGH
					if (code.PIN_DETAILS.GPIO_PIN_4.PIN_STATUS == 1) 
					{
						My_GPIO_Pin_4.GetComponent<Bread> ().voltage = 5;

					}
					//CHECK PIN 4 LOW
					else if (code.PIN_DETAILS.GPIO_PIN_4.PIN_STATUS == 0) 
					{
						My_GPIO_Pin_4.GetComponent<Bread> ().voltage = 0;

					} 
				}

				// CHECK PIN 14 OUTPUT
				if (code.PIN_DETAILS.GPIO_PIN_14.PIN_MODE == 2) 
				{
					//CHECK PIN 14 HIGH
					if (code.PIN_DETAILS.GPIO_PIN_14.PIN_STATUS == 1) 
					{
						My_GPIO_Pin_14.GetComponent<Bread> ().voltage = 5;

					}
					//CHECK PIN 14 LOW
					else if (code.PIN_DETAILS.GPIO_PIN_14.PIN_STATUS == 0) 
					{
						My_GPIO_Pin_14.GetComponent<Bread> ().voltage = 0;

					} 
				}

				// CHECK PIN 17 OUTPUT
				if (code.PIN_DETAILS.GPIO_PIN_17.PIN_MODE == 2) 
				{
					//CHECK PIN 17 HIGH
					if (code.PIN_DETAILS.GPIO_PIN_17.PIN_STATUS == 1) 
					{
						My_GPIO_Pin_17.GetComponent<Bread> ().voltage = 5;

					}
					//CHECK PIN 17 LOW
					else if (code.PIN_DETAILS.GPIO_PIN_17.PIN_STATUS == 0) 
					{
						My_GPIO_Pin_17.GetComponent<Bread> ().voltage = 0;

					} 
				}

				// CHECK PIN 18 OUTPUT
				if (code.PIN_DETAILS.GPIO_PIN_18.PIN_MODE == 2) 
				{
					//CHECK PIN 18 HIGH
					if (code.PIN_DETAILS.GPIO_PIN_18.PIN_STATUS == 1) 
					{
						My_GPIO_Pin_18.GetComponent<Bread> ().voltage = 5;

					}
					//CHECK PIN 18 LOW
					else if (code.PIN_DETAILS.GPIO_PIN_18.PIN_STATUS == 0) 
					{
						My_GPIO_Pin_18.GetComponent<Bread> ().voltage = 0;

					} 
				}

				// CHECK PIN 27 OUTPUT
				if (code.PIN_DETAILS.GPIO_PIN_27.PIN_MODE == 2) 
				{
					//CHECK PIN 27 HIGH
					if (code.PIN_DETAILS.GPIO_PIN_27.PIN_STATUS == 1) 
					{
						My_GPIO_Pin_27.GetComponent<Bread> ().voltage = 5;

					}
					//CHECK PIN 27 LOW
					else if (code.PIN_DETAILS.GPIO_PIN_27.PIN_STATUS == 0) 
					{
						My_GPIO_Pin_27.GetComponent<Bread> ().voltage = 0;

					} 
				}

				// CHECK PIN 22 OUTPUT
				if (code.PIN_DETAILS.GPIO_PIN_22.PIN_MODE == 2) 
				{
					//CHECK PIN 22 HIGH
					if (code.PIN_DETAILS.GPIO_PIN_22.PIN_STATUS == 1) 
					{
						My_GPIO_Pin_22.GetComponent<Bread> ().voltage = 5;

					}
					//CHECK PIN 22 LOW
					else if (code.PIN_DETAILS.GPIO_PIN_22.PIN_STATUS == 0) 
					{
						My_GPIO_Pin_22.GetComponent<Bread> ().voltage = 0;

					} 
				}

				// CHECK PIN 23 OUTPUT
				if (code.PIN_DETAILS.GPIO_PIN_23.PIN_MODE == 2) 
				{
					//CHECK PIN 23 HIGH
					if (code.PIN_DETAILS.GPIO_PIN_23.PIN_STATUS == 1) 
					{
						My_GPIO_Pin_23.GetComponent<Bread> ().voltage = 5;

					}
					//CHECK PIN 23 LOW
					else if (code.PIN_DETAILS.GPIO_PIN_23.PIN_STATUS == 0) 
					{
						My_GPIO_Pin_23.GetComponent<Bread> ().voltage = 0;

					} 
				}

				// CHECK PIN 24 OUTPUT
				if (code.PIN_DETAILS.GPIO_PIN_24.PIN_MODE == 2) 
				{
					//CHECK PIN 24 HIGH
					if (code.PIN_DETAILS.GPIO_PIN_24.PIN_STATUS == 1) 
					{
						My_GPIO_Pin_24.GetComponent<Bread> ().voltage = 5;

					}
					//CHECK PIN 24 LOW
					else if (code.PIN_DETAILS.GPIO_PIN_24.PIN_STATUS == 0) 
					{
						My_GPIO_Pin_24.GetComponent<Bread> ().voltage = 0;

					} 
				}

				// CHECK PIN 10 OUTPUT
				if (code.PIN_DETAILS.GPIO_PIN_10.PIN_MODE == 2) 
				{
					//CHECK PIN 10 HIGH
					if (code.PIN_DETAILS.GPIO_PIN_10.PIN_STATUS == 1) 
					{
						My_GPIO_Pin_10.GetComponent<Bread> ().voltage = 5;

					}
					//CHECK PIN 10 LOW
					else if (code.PIN_DETAILS.GPIO_PIN_10.PIN_STATUS == 0) 
					{
						My_GPIO_Pin_10.GetComponent<Bread> ().voltage = 0;

					} 
				}

				// CHECK PIN 9 OUTPUT
				if (code.PIN_DETAILS.GPIO_PIN_9.PIN_MODE == 2) 
				{
					//CHECK PIN 9 HIGH
					if (code.PIN_DETAILS.GPIO_PIN_9.PIN_STATUS == 1) 
					{
						My_GPIO_Pin_9.GetComponent<Bread> ().voltage = 5;

					}
					//CHECK PIN 9 LOW
					else if (code.PIN_DETAILS.GPIO_PIN_9.PIN_STATUS == 0) 
					{
						My_GPIO_Pin_9.GetComponent<Bread> ().voltage = 0;

					} 
				}

				// CHECK PIN 25 OUTPUT
				if (code.PIN_DETAILS.GPIO_PIN_25.PIN_MODE == 2) 
				{
					//CHECK PIN 25 HIGH
					if (code.PIN_DETAILS.GPIO_PIN_25.PIN_STATUS == 1) 
					{
						My_GPIO_Pin_25.GetComponent<Bread> ().voltage = 5;

					}
					//CHECK PIN 25 LOW
					else if (code.PIN_DETAILS.GPIO_PIN_25.PIN_STATUS == 0) 
					{
						My_GPIO_Pin_25.GetComponent<Bread> ().voltage = 0;

					} 
				}

				// CHECK PIN 11 OUTPUT
				if (code.PIN_DETAILS.GPIO_PIN_11.PIN_MODE == 2) 
				{
					//CHECK PIN 11 HIGH
					if (code.PIN_DETAILS.GPIO_PIN_11.PIN_STATUS == 1) 
					{
						My_GPIO_Pin_11.GetComponent<Bread> ().voltage = 5;

					}
					//CHECK PIN 11 LOW
					else if (code.PIN_DETAILS.GPIO_PIN_11.PIN_STATUS == 0) 
					{
						My_GPIO_Pin_11.GetComponent<Bread> ().voltage = 0;

					} 
				}

				// CHECK PIN 8 OUTPUT
				if (code.PIN_DETAILS.GPIO_PIN_8.PIN_MODE == 2) 
				{
					//CHECK PIN 8 HIGH
					if (code.PIN_DETAILS.GPIO_PIN_8.PIN_STATUS == 1) 
					{
						My_GPIO_Pin_8.GetComponent<Bread> ().voltage = 5;

					}
					//CHECK PIN 8 LOW
					else if (code.PIN_DETAILS.GPIO_PIN_8.PIN_STATUS == 0) 
					{
						My_GPIO_Pin_8.GetComponent<Bread> ().voltage = 0;

					} 
				}

				// CHECK PIN 7 OUTPUT
				if (code.PIN_DETAILS.GPIO_PIN_7.PIN_MODE == 2) 
				{
					//CHECK PIN 7 HIGH
					if (code.PIN_DETAILS.GPIO_PIN_7.PIN_STATUS == 1) 
					{
						My_GPIO_Pin_7.GetComponent<Bread> ().voltage = 5;

					}
					//CHECK PIN 7 LOW
					else if (code.PIN_DETAILS.GPIO_PIN_7.PIN_STATUS == 0) 
					{
						My_GPIO_Pin_7.GetComponent<Bread> ().voltage = 0;

					} 
				}
			}


			else
			{
				My_GPIO_Pin_23.GetComponent<Bread> ().voltage = -1;
			}

		}
		else
		{
			Debug.Log("WWW Error: "+ www.error);
		}    
	}
}
