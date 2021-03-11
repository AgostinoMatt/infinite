using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreTable : MonoBehaviour
{
    private Transform entryContainer;
    private Transform entryTemplate;
    //private List<HighScoreEntry> highScoreEntryList;
    private List<Transform> highScoreEntryTransformList;

    private void Awake()
    {
        entryContainer = transform.Find("highScoreEntryContainer");
        entryTemplate = entryContainer.Find("highScoreEntry");

        entryTemplate.gameObject.SetActive(false);

        float templateHeight = 20f;
        for(int i = 0; i < 10; i++)
        {
            Transform entryTransform = Instantiate(entryTemplate, entryContainer);
            RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
            entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * i);
            entryTransform.gameObject.SetActive(true);

        }

        /*
        highScoreEntryList = new List<HighScoreEntry>()
        {
            new HighScoreEntry{ score = 511825, name = "AAA" },
            new HighScoreEntry{ score = 346874, name = "BOB" },
            new HighScoreEntry{ score = 345346, name = "DOG" },
            new HighScoreEntry{ score = 865435, name = "CID" },
            new HighScoreEntry{ score = 645324, name = "JON" },
            new HighScoreEntry{ score = 123125, name = "AJQ" },
        };

        //sort entry by score
        for (int i = 0; i < highScoreEntryList.Count; i++)
        {
            for (int j = i + i; j < highScoreEntryList.Count; j++)
            {
                if (highScoreEntryList[j].score > highScoreEntryList[i].score)
                {
                    //swap
                    HighScoreEntry tmp = highScoreEntryList[i];
                    highScoreEntryList[i] = highScoreEntryList[j];
                    highScoreEntryList[j] = tmp;
                }
            }
        }

        highScoreEntryTransformList = new List<Transform>();
        foreach (HighScoreEntry highScoreEntry in highScoreEntryList)
        {
            CreateHighScoreEntryTransform(highScoreEntry, entryContainer, highScoreEntryTransformList);
        }
        */
        
    }

    /*
        private void CreateHighScoreEntryTransform(HighScoreEntry highScoreEntry, Transform container, List<Transform> transformList)
    {
            float templateHeight = 30f;

            Transform entryTransform = Instantiate(entryTemplate, container);
            RectTransform entryRecTransform = entryTransform.GetComponent<RectTransform>();
            entryRecTransform.anchoredPosition = new Vector2(0, -templateHeight * transformList.Count);
            entryTransform.gameObject.SetActive(true);

            int rank = transformList.Count + 1;
            string rankString;
            switch (rank)
            {
                default:
                    rankString = rank + "TH"; break;
                case 1: rankString = "1ST"; break;
                case 2: rankString = "2ND"; break;
                case 3: rankString = "3RD"; break;
            }

            entryTransform.Find("posText").GetComponent<Text>().text = rankString;

        int score = highScoreEntry.score;

            entryTransform.Find("scoreText").GetComponent<Text>().text = score.ToString();

            string name = highScoreEntry.name;
            entryTransform.Find("nameText").GetComponent<Text>().text = name;

        transformList.Add(entryTransform);

        
    }
    */
        
    

    /*
     * Single High Score Entry
     * 
    private class HighScoreEntry
    {
        public int score;
        public string name;
    }*/

}
