using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameAnalyticsSDK;

public class SampleAnalytics : MonoBehaviour
{
    private IEnumerator Start()
    {
        GameAnalytics.Initialize();

        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, "World_01", "Stage_01", "Level_Progress");

        yield return new WaitForSeconds(10);
        
        if (Random.value > 0.5f)
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, "World_01", "Stage_01", "Level_Progress");
        else
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Fail, "World_01", "Stage_01", "Level_Progress");
    }
}
