// Decompiled with JetBrains decompiler
// Type: KerbalCullingManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KerbalCullingManager : KerbalMonoBehaviour, ICullingGroupManager
{
  public static KerbalCullingManager Singleton;
  private float[] portraitCamDistanceBands;
  private float[] flightCamDistanceBands;
  private CullingSparseSet sphereSet;
  private CullingGroup mainCameraGroup;
  private List<KerbalCullingManager.PortraitCullingGroup> portraitGroups;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ReleaseSphere(int index) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public int ReserveSphere(Action<CullingGroup, CullingGroupEvent> callback) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnMainCameraCullingGroupEvent(CullingGroupEvent groupEvent) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetSphere(int index, Vector3 center, float radius) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetPortraitCameras(
    IReadOnlyList<(Camera Camera, int SeatIndex)> cameraList)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KerbalCullingManager() => throw null;

  private class PortraitCullingGroup
  {
    public CullingGroup group;
    public KerbalCullingManager cullingManager;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PortraitCullingGroup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPortraitCameraCullingGroupEvent(CullingGroupEvent groupEvent) => throw null;
  }
}
