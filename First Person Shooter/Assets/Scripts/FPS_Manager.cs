using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_Manager : MonoBehaviour
{
    void Awake()
    {
        Application.targetFrameRate = -1;
        QualitySettings.vSyncCount = 0;
    }
}
