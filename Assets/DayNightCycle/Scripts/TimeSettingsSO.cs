using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

[CreateAssetMenu(fileName = "TimeSettings", menuName = "TimeSettings")]
public class TimeSettingsSO : ScriptableObject
{
    public float realtimeMinutes = 15;
    public float startHour = 12;
    public float sunriseHour = 6;
    public float sunsetHour = 18;

    public float TimeMultiplier => (24f * 60 * 60) / (realtimeMinutes * 60f);
}