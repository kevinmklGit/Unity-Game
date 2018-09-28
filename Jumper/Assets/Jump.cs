using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		        NextCube ();

            }

            GameObject NextCube() {

                GameObject[] gos;
                gos = GameObject.FindGameObjectsWithTag("cube");
                GameObject closest = null;
                float distance = Math.Infinity;
                Vector3 position = transform.position;
                foreach (GameObject go in gos) {
                    Vector3 diff = go.transform.position - position;

                    float curDistance = diff.sqrMagnitude;
                    if (curDistance < distance) {
                        closest = go;
                        distance = curDistance;
                    }
                }
                return closest;
	}
}
