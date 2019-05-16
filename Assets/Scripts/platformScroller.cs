using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformScroller : MonoBehaviour
{

    public float scrollSpeed = 5.0f;

    public GameObject[] plat;
    public float frequency = 0.5f;
    float counter = 0.0f;
    public Transform platformSpawnPoint;

    bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        GenerateRandomPlatform();

    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver) return;
        //generate platform
        if (counter <= 0.0)
        {
            GenerateRandomPlatform();
        }
        else
        {
            counter -= Time.deltaTime * frequency;
        }
        GameObject currentChild;
        for (int i = 0; i < transform.childCount; i++ )
        {
            currentChild = transform.GetChild(i).gameObject;
            scrollPlatform(currentChild); 
            if (currentChild.transform.position.x <= -20.0f)
            {
                Destroy(currentChild); 
            }
        }
    }

    void scrollPlatform (GameObject currentPlatform)
    {
        currentPlatform.transform.position -= Vector3.right * (scrollSpeed * Time.deltaTime); 
    }

    void GenerateRandomPlatform()
    {
        GameObject newPlatform = Instantiate(plat[Random.Range(0, plat.Length)], platformSpawnPoint.position, Quaternion.identity) as GameObject;
        newPlatform.transform.parent = transform;
        counter = 1.0f;
    }

    public void GameOver()
    {
        isGameOver = true;
    }
}
