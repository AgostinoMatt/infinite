using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelgenerater : MonoBehaviour
{
    
    [SerializeField] private Transform level_Start;
    [SerializeField] private Transform levelPart_1;

    private Vector3 lastEndPosition;

    private void Awake()
    {
        lastEndPosition = level_Start.Find("EndPosition").position;
        SpawnLevelPart();
    }

    private void SpawnLevelPart()
    {
        Transform lastLevelPartTransform = SpawnLevelPart(lastEndPosition);
        lastEndPosition = lastLevelPartTransform.Find("EndPosition").position;
    }

    private Transform SpawnLevelPart(Vector3 spawnPosition)
    {
        Transform levelPartTransform = Instantiate(levelPart_1, spawnPosition, Quaternion.identity);
        return levelPartTransform;
    }
}
