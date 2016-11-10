using UnityEngine;
using System.Collections;

public class BadAI : MonoBehaviour
{
    private Transform ballTransform;

	void Start ()
    {
        ballTransform = FindObjectOfType<Ball>().transform;
	}
	
	void Update ()
    {
        Vector3 newPos = transform.position;
        newPos.y = ballTransform.position.y;
        transform.position = newPos;
	}
}
