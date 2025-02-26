﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchivementSystem : Observer
{
    private void Start()
    {
        PlayerPrefs.DeleteAll();

        foreach (var poi in FindObjectsOfType<PointOfInterest>())
        {
            poi.RegisterObserver(this);
        }
    }

    public override void OnNotify(object value, NotificationType notificationType)
    {
        if (notificationType == NotificationType.AchievementUnlocked)
        {
            string achivementKey = "achivement-" + value;

            if (PlayerPrefs.GetInt(achivementKey) == 1)
            {
                return;
            }

            PlayerPrefs.SetInt(achivementKey, 1);
            Debug.Log("Unlocked " + value);
        }
    }
}

public enum NotificationType
{
    AchievementUnlocked
}


