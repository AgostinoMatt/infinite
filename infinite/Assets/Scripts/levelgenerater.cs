﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelgenerater : MonoBehaviour
{
    private const float PLAYER_DISTANCE_SPAWN_LEVEL_PART = 200f;


    [SerializeField] private Transform level_Start;
    [SerializeField] private List<Transform> levelPartList;
    [SerializeField] private Player player;

    private Transform lastEndPosition;

    private void Awake()
    {
        lastEndPosition = level_Start.Find("EndPosition");

        int startingSpawnLevelPart = 5;
        for (int i = 0; i < startingSpawnLevelPart; i++)
        {
            SpawnLevelPart();
        }

    }
    private void Update()
    {
        if ((lastEndPosition.position.z - player.GetPosition().z) < PLAYER_DISTANCE_SPAWN_LEVEL_PART)
        {
            SpawnLevelPart();
            Debug.Log("pew");
        }
        float dist = lastEndPosition.position.z - player.GetPosition().z;
        print(lastEndPosition);
    }

    private void SpawnLevelPart()
    {
        Transform chosenLevelPart = levelPartList[Random.Range(0, levelPartList.Count)];
        Transform lastLevelPartTransform = SpawnLevelPart(chosenLevelPart, lastEndPosition.position);
        lastEndPosition = lastLevelPartTransform.Find("EndPosition");
    }

    private Transform SpawnLevelPart(Transform levelPart, Vector3 spawnPosition)
    {
        Transform levelPartTransform = Instantiate(levelPart, spawnPosition, Quaternion.identity);
        return levelPartTransform;
    }
}