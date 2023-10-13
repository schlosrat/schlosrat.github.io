// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.TimeOfDayManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
    [SerializeField]
    [Header("Position IDs")]
    private string _bodyID;
    [SerializeField]
    private string _objectID;
    [Header("Time of Day")]
    [SerializeField]
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
