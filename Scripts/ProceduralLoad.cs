using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralLoad : MonoBehaviour {

    // Use this for initialization
    float worldOffset = 144;
    float xOffset = 12;
    [SerializeField]GameObject _Platform;
    [SerializeField] GameObject _worldLayout;
    float counter = 2;
    float worldCounter = 5;


	void Start () {
		//Work on the procedural loading of the platforms
	}
	
	// Update is called once per frame
	void Update () {
        counter -= 1 * Time.deltaTime;
        worldCounter -= +1 * Time.deltaTime;
        if (counter <= 0)
        {
            counter = 2;
            LoadPlatforms();
            xOffset += 12;
        }

        if(worldCounter < 0)
        {
            worldCounter = 5;
            LoadWorld();
            worldOffset += 144;
        }

	}

    void LoadPlatforms()
    {
        Vector3 SpawnPoint = new Vector3(_Platform.transform.position.x + xOffset, Mathf.CeilToInt(Random.Range(-8, 0)), _Platform.transform.position.z);
        Instantiate(_Platform, SpawnPoint, Quaternion.identity);

    }

    void LoadWorld()
    {
        Vector3 SpawnPoint = new Vector3(_worldLayout.transform.position.x + worldOffset, _worldLayout.transform.position.y , _worldLayout.transform.position.z);
        Instantiate(_worldLayout, SpawnPoint, Quaternion.identity);
    }
}
