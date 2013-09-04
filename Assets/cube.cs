using UnityEngine;
using System.Collections;

public class cube : MonoBehaviour {

    public GameObject Broken;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        Instantiate(Broken, transform.position, Broken.transform.rotation);
        Destroy(gameObject);
    }
}
