using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] Transform startPoint;
    [SerializeField] Transform endPoint;
	[SerializeField] float repeatTime;
    [SerializeField] Monster monsterPrefab;

    Coroutine coroutine;

	private void OnEnable()
	{
		coroutine = StartCoroutine(MonsterSpawn());
	}
	private void OnDisable()
	{
		StopCoroutine(coroutine);
	}

	IEnumerator MonsterSpawn()
	{
		while ( true )
		{
			yield return new WaitForSeconds(repeatTime);
			Monster monster = Instantiate(monsterPrefab, startPoint.position, startPoint.rotation);
			monster.Moving(endPoint);
		}
	}

	
}
