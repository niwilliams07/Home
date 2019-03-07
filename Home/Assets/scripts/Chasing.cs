using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Chasing : MonoBehaviour
{

	public Transform target;
	public float speed = 2f;
	private float Distance = 10f;
	private float range;

	void Update ()
	{
		range = Vector2.Distance(transform.position, target.position);

		if (range < Distance)
		{
			transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
		}
	}
}