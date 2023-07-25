// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.ReentryVFXRenderer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim.impl;
using KSP.VFX;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering.Planets
{
  public class ReentryVFXRenderer : VesselVFXManagerBase
  {
    private VesselBehavior _vesselBehavior;
    private VesselComponent _vesselComponent;
    private GameObject _flightCamera;
    private GameInstance _gameInstance;
    private bool _isMainVessel;
    private ReentryEffect _highQualityEffect;
    private GameObject _highQualityGameObject;
    private ReentryEffect _medQualityEffect;
    private GameObject _medQualityGameObject;
    private ReentryEffect _lowQualityEffect;
    private GameObject _lowQualityGameObject;
    private GameObject _mainParticleGameObject;
    private ParticleSystem _mainParticles;
    private Material _reentryMaterial;

    public VesselComponent VesselComponent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsMainVessel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ReentryVFXRenderer(
      VesselVFXManagerBase.EffectQuality effectQuality,
      VesselBehavior vessel,
      Material reentryMaterial)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateReentryObjects() => throw null;
  }
}
