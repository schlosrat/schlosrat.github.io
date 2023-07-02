// Decompiled with JetBrains decompiler
// Type: KSP.Sim.CameraTweakables
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim
{
  [JsonObject(MemberSerialization.OptIn)]
  [CreateAssetMenu(fileName = "CameraTweakables", menuName = "ScriptableObjects/CameraTweakables", order = 66)]
  public class CameraTweakables : ScriptableObject
  {
    private const string CURRENT_TWEAKABLES_VERSION = "0.2";
    private const float DEFAULT_ORBIT_SENSITIVITY = 4.5f;
    private const float DEFAULT_SCROLL_SENSITIVITY = 1f;
    private const float DEFAULT_PAN_SENSITIVITY = 2f;
    public string CameraTweakablesName;
    [JsonProperty]
    public string TweakablesVersion;
    [JsonProperty]
    public float orbitSensitivity;
    [JsonProperty]
    public float scrollSensitivity;
    [JsonProperty]
    public float panSensitivity;
    public FlightCameraContext cameraContext;
    public CameraUpRelative upRelative;
    [JsonProperty]
    public Vector3 localOffset;
    [JsonProperty]
    public double defaultFOV;
    [JsonProperty]
    public double defaultSize;
    [Range(0.0f, -90f)]
    [Tooltip("A value from 0 to -90 that determines how far the camera can manually pitch down.")]
    [JsonProperty]
    public double minPitch;
    [Range(0.0f, 90f)]
    [Tooltip("A value from 0 to 90 that determines how far the camera can manually pitch up.")]
    [JsonProperty]
    public double maxPitch;
    [JsonProperty]
    [Tooltip("How far in the camera can be zoomed from its focal point.")]
    public double minDistance;
    [JsonProperty]
    [Tooltip("How far the camera is zoomed from its focal point by default")]
    public double DefaultDistance;
    [JsonProperty]
    [Tooltip("How far out the camera can be zoomed out from its focal point.")]
    public double maxDistance;
    [JsonProperty]
    public double minFOV;
    [JsonProperty]
    public double maxFOV;
    [JsonProperty]
    public double minSize;
    [JsonProperty]
    public double maxSize;
    [JsonProperty]
    public float maxPanAngle;
    [JsonProperty]
    public float minPanAngle;
    [JsonProperty]
    [Tooltip("The maximum distance the camera can pan away from the focal point.")]
    public float maxPanDistance;
    [JsonProperty]
    [Tooltip("The minimum distance the camera can pan away from the focal point.")]
    public float fineMovementModifier;
    [Tooltip("Duration in seconds for camera blend after switching camera mode.")]
    [JsonProperty]
    [Min(0.0f)]
    public float switchCameraModeBlendDuration;
    [Tooltip("Function to use during camera blend after switching camera mode.")]
    [JsonProperty]
    public BlendFunction switchCameraModeBlendFunction;
    [Min(0.0f)]
    [JsonProperty]
    public float terrainCollisionBuffer;
    [JsonProperty]
    public int terrainRaycastBufferSize;
    [Tooltip("Duration in seconds for camera blend to kick in after no collision.")]
    [JsonProperty]
    [Min(0.0f)]
    public float terrainCollisionCameraBlendDelay;
    [Min(0.0f)]
    [Tooltip("Duration in seconds for camera blend after terrain collision.")]
    [JsonProperty]
    public float terrainCollisionCameraBlendDuration;
    [JsonProperty]
    [Tooltip("Function to use during camera blend after terrain collision.")]
    public BlendFunction terrainCollisionCameraBlendFunction;
    [JsonProperty]
    public bool lockCursor;
    [Tooltip("Flag that makes the camera check if the cursor is over UI elements before applying zoom in and zoom out.")]
    [JsonProperty]
    public bool BlockZoomOverUI;
    [Tooltip("Tag names that will be checked if collection is not null or empty, for selectively block zoom when hovering UI elements with the cursor.")]
    [JsonProperty]
    public string[] TagsForZoomBlock;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Multiply(float multiplier) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(string tweakablesName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SaveConfigToFile() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void LoadConfigFromFile(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnApplySavedConfiguration(CameraTweakables savedConfig, bool addressable = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraTweakables() => throw null;
  }
}
