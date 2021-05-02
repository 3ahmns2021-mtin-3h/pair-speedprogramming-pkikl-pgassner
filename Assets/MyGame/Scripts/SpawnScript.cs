using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject flower1;
    public GameObject parent;
    private float radius = 1.2f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Instantiate(flower1, Random.insideUnitSphere * radius + transform.position, Random.rotation);
            GameObject flowerSpawner = Instantiate(flower1);
            flowerSpawner.GetComponent<Transform>().SetParent(parent.GetComponent<Transform>(), false);
            flowerSpawner.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-550, 550), Random.Range(-300, 300), 0);
            flowerSpawner.GetComponent<Transform>().localRotation = Quaternion.identity;
            flowerSpawner.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
    }
}
