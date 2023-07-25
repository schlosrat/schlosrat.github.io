// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.ShadowSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.OAB;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  public class ShadowSystem : MonoBehaviour
  {
    public GraphicsManager graphicsManager;
    [SerializeField]
    private ShadowSettings _shadowSettings;
    [SerializeField]
    private float _surfaceTransitionAltitude;
    [SerializeField]
    private float _orbitTransitionAltitude;
    private List<DirectionalLightShadowController> _shadowControllers;
    private DirectionalLightShadowController _shadowControllerVAB;
    private ShadowMapRenderer _scaledShadowmapRenderer;
    private bool _inFlightView;
    private bool _inOAB;
    private ShadowConfig _curShadowConfig;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyBehavior GetSOIBody() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Camera GetCurrentUnityCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Camera GetCurrentScaledUnityCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFlightViewEntered() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFlightViewExited() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnKSCReturn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnOABLoaded(OABEnvironmentType oabType, DirectionalLightShadowController dlsc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnOABUnloaded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupLightShadowController(DirectionalLightShadowController dlsc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveLightShadowController(DirectionalLightShadowController dlsc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateDLSC(DirectionalLightShadowController dlsc, ShadowConfig config) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateCurrentShadowConfig() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SyncAllControllers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ShadowSystem() => throw null;
  }
}
