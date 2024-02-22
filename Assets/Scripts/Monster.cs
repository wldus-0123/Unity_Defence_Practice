using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;

	private void Update()
	{
		Arriving();
	}
	public void Moving(Transform destination)
    {
		agent.destination = destination.position;
	}

    private void Arriving()
    {
		if((transform.position - agent.destination).sqrMagnitude < 0.1f)
		{
			Debug.Log("¸ñÀûÁö µµÂø");
			Destroy(gameObject);
		}
    }
}
