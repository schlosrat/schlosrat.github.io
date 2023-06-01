// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.TimeOfDayManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  public class TimeOfDayManager : KerbalMonoBehaviour
  {
    private GraphicsManager GraphicsManager;
    private UniverseCameraManager CameraManager;
    [Header("Position IDs")]
    [SerializeField]
    private string _bodyID;
    [SerializeField]
    private string _objectID;
    [SerializeField]
    [Header("Time of Day")]
    private float _sunriseTime;
    [SerializeField]
    private float _sunsetTime;
    public bool LightsEnabled;
    [SerializeField]
    private PrefabLight[] _prefabLights;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleLights(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeOfDayManager() => throw null;
  }
}
