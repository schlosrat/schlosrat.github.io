// Decompiled with JetBrains decompiler
// Type: KSP.Sim.CameraTweakables
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim
{
  [JsonObject(MemberSerialization.OptIn)]
  public class CameraTweakables : KerbalMonoBehaviour
  {
    private const string CURRENT_TWEAKABLES_VERSION = "0.2";
    private const float DEFAULT_ORBIT_SENSITIVITY = 4.5f;
    private const float DEFAULT_SCROLL_SENSITIVITY = 1f;
    private const float DEFAULT_PAN_SENSITIVITY = 2f;
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
    [JsonProperty]
    [Range(0.0f, -90f)]
    [Tooltip("A value from 0 to -90 that determines how far the camera can manually pitch down.")]
    public double minPitch;
    [Range(0.0f, 90f)]
    [JsonProperty]
    [Tooltip("A value from 0 to 90 that determines how far the camera can manually pitch up.")]
    public double maxPitch;
    [Tooltip("How far in the camera can be zoomed from its focal point.")]
    [JsonProperty]
    public double minDistance;
    [Tooltip("How far the camera is zoomed from its focal point by default")]
    [JsonProperty]
    public double DefaultDistance;
    [Tooltip("How far out the camera can be zoomed out from its focal point.")]
    [JsonProperty]
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
    [Tooltip("The maximum distance the camera can pan away from the focal point.")]
    [JsonProperty]
    public float maxPanDistance;
    [JsonProperty]
    [Tooltip("The minimum distance the camera can pan away from the focal point.")]
    public float fineMovementModifier;
    [Min(0.0f)]
    [Tooltip("Duration in seconds for camera blend after switching camera mode.")]
    [JsonProperty]
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
    [Tooltip("Duration in seconds for camera blend after terrain collision.")]
    [JsonProperty]
    [Min(0.0f)]
    public float terrainCollisionCameraBlendDuration;
    [Tooltip("Function to use during camera blend after terrain collision.")]
    [JsonProperty]
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
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SaveConfigToFile() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void LoadConfigFromFile() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraTweakables() => throw null;
  }
}
