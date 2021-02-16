using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelgenerater : MonoBehaviour
{
    private const float PLAYER_DISTANCE_SPAWN_LEVEL_PART = 200f;


    [SerializeField] private Transform level_Start;
    [SerializeField] private Transform levelPart_1;
    [SerializeField] private Player player;

    private Vector3 lastEndPosition;

    private void Awake()
    {
        lastEndPosition = level_Start.Find("EndPosition").position;

        int startingSpawnLevelPart = 5;
        for (int i = 0; i < startingSpawnLevelPart; i++)
        {
            SpawnLevelPart();
        }

    }
    private void Update()
    {
        if (Vector3.Distance(player.GetPosition(), lastEndPosition) < PLAYER_DISTANCE_SPAWN_LEVEL_PART)
        {
            SpawnLevelPart();
        }
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
