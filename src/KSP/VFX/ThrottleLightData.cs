// Decompiled with JetBrains decompiler
// Type: KSP.VFX.ThrottleLightData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  [DisableCustomEditorBase]
  [DisallowMultipleComponent]
  public class ThrottleLightData : KerbalMonoBehaviour, IEngineFXData
  {
    public bool CtrlAllLightsUnderThisTransform;
    public AnimationCurve LightIntensityCurve;
    public AnimationCurve LightRangeCurve;
    private Light[] _lights;

    public Action<float, float, float, Vector3> TriggerUpdateVisuals
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleVisibility(bool doTurnOn, ParticleSystemStopBehavior stopBehaviour = ParticleSystemStopBehavior.StopEmitting) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateVisuals(
      float curThrust,
      float curAtmo,
      float curAngleVel,
      Vector3 curAccelerationDir)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ThrottleLightData() => throw null;
  }
}
