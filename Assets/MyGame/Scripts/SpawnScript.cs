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
            var clones = Instantiate(flower1);
            clones.GetComponent<Transform>().SetParent(parent.GetComponent<Transform>(), false);
            clones.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-400, 400), Random.Range(-400, 400), 0);
            clones.GetComponent<Transform>().localRotation = Quaternion.identity;
            clones.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
    }
}
