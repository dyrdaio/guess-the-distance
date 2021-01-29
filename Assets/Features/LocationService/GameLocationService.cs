using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Linq;
using System;
using DyrdaIo.Singleton;

public class GameLocationService : SingletonMonoBehaviour<GameLocationService>
{
    [HideInInspector] public bool locationServiceInitialized = false;
    [HideInInspector] public LocationInfo currentLocationInfo;

    public void Start()
    {
        StartCoroutine("StartLocationService");
    }

    public void Update()
    {
        if (locationServiceInitialized)
        {
            currentLocationInfo = Input.location.lastData;
        }
    }

    private IEnumerator StartLocationService()
    {
        throw new NotImplementedException();
    }

    public static Vector3 GPSToWorld(double lat, double lon, double alt, double rad)
    {
        throw new NotImplementedException();
    }

    public static float DistanceInKm(float lat1, float lon1, float lat2, float lon2)
    {
        throw new NotImplementedException();
    }
}