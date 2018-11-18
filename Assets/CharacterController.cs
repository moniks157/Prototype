using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour {

    public Text txt;
    public Button btn;
    public List<Transform> roads;

    public int currentRoad = 1;

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(roads[currentRoad].position.x,1,0);
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(currentRoad != roads.Count - 1)
            {
                currentRoad++;
                transform.position = new Vector3(roads[currentRoad].position.x, 1, 0);
            }
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (currentRoad != 0)
            {
                currentRoad--;
                transform.position = new Vector3(roads[currentRoad].position.x, 1, 0);
            }
        }

	}

    private void OnTriggerEnter(Collider other)
    {
        txt.gameObject.SetActive(true);
        btn.gameObject.SetActive(true);
    }

    public void OnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
