// Decompiled with JetBrains decompiler
// Type: KSP.VFX.VFXQualitySetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  [Serializable]
  public class VFXQualitySetting
  {
    [Header("Enable Effect Type")]
    public bool ExplosionVFXEnabled;
    public bool DetachmentVFXEnabled;
    public bool SurfaceImpactVFXEnabled;
    public bool PersistentSurfaceContactVFXEnabled;
    public bool WheelSurfaceContactVFXEnabled;
    public bool GroundBlastVFXEnabled;
    public bool ShockConeVFXEnabled;
    public bool WingipVortexVFXEnabled;
    public bool ContrailVFXEnabled;
    public bool ReentryVFXEnabled;
    public bool DecoupleVFXEnabled;
    public bool ParachuteDeployVFXEnabled;
    public bool KerbalPoofVFXEnabled;
    public bool KerbalFootstepVFXEnabled;
    public bool LaunchSmokeVFXEnabled;
    public bool LaunchFireVFXEnabled;
    public bool LaunchFuelTankIceVFXEnabled;
    public bool EngineVFXEnabled;
    [Tooltip("Cell sizes for nested aggregation groups in the spatial db graph. The last one determines the radius in which VFX instances will be aggregated.")]
    [Header("Instance aggregation")]
    public List<float> FXAggregatorSpatialDBCellSizes;
    [Tooltip("Maximum size in Explosion Potential that fx instances can be combined into. Anything larger will be clamped to this value")]
    public float FXAggregatorAggregationLimit;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool EffectEnabled(VFXEventType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetEffectEnabled(VFXEventType type, bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VFXQualitySetting() => throw null;
  }
}
