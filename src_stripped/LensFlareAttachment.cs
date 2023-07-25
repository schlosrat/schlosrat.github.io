// Decompiled with JetBrains decompiler
// Type: LensFlareAttachment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LensFlareAttachment : MonoBehaviour
{
  public Camera scaledCamera;
  public Camera physicsCamera;
  private ProFlare scaledProFlare;
  private ProFlare physicsProFlare;
  private ProFlareBatch scaledProFlareBatch;
  private ProFlareBatch physicsProFlareBatch;
  private GameObject scaledFlareObj;
  private GameObject physicsFlareObj;

  public CelestialBodyComponent sun
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public CelestialBodyBehavior celestialBody
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public IUniverseView universeView
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public IUniverseObserver universeObserver
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  private IScaledSpaceProvider ScaledSpace
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  private IPhysicsSpaceProvider PhysicsSpace
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetUpLensFlare() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateCamera(LensFlareAttachment.flareMode mode) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnExitMapView() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnterMapView() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public LensFlareAttachment() => throw null;

  private enum flareMode
  {
    scaled,
    physics,
  }
}
