using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{

    public GameObject arrowPreb;
    float span = 1.0f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            this.span = Random.Range(0.1f, 1.0f);
            GameObject go = Instantiate(arrowPreb) as GameObject;
            float px = Random.Range(-2.0f, 2.0f);
            go.transform.position = new Vector3(px, 6.0f, 0);
        }
    }
}
