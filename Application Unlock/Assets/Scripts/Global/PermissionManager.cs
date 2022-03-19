using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PermissionManager : MonoBehaviour
{
    private void Awake()
    {
        #region Mic Permission
        AndroidRuntimePermissions.Permission resultMic = AndroidRuntimePermissions.RequestPermission("android.permission.RECORD_AUDIO");
        if (resultMic == AndroidRuntimePermissions.Permission.Granted)
        {
            Debug.Log("We have permission to access the stepcounter");
            Debug.LogWarning("<b>PERMISSION GRANTED</b>");
        }
        else
        {
            Debug.LogError("<b>NO PERMISSION</b>");
            Debug.Log("Permission state: " + resultMic); // No permission
        }
        #endregion


        #region Sensor Permission
        AndroidRuntimePermissions.Permission resultSensor = AndroidRuntimePermissions.RequestPermission("android.permission.ACTIVITY_RECOGNITION");
        if (resultSensor == AndroidRuntimePermissions.Permission.Granted)
        {
            Debug.Log("We have permission to access the stepcounter");
            Debug.LogWarning("<b>PERMISSION GRANTED</b>");
        }
        else
        {
            Debug.LogError("<b>NO PERMISSION</b>");
            Debug.Log("Permission state: " + resultSensor); // No permission
        }
        #endregion
    }
}
