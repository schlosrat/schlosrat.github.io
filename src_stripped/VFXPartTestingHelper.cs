// Decompiled with JetBrains decompiler
// Type: VFXPartTestingHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Rendering.Planets;
using KSP.Sim.Definitions;
using KSP.Tools;
using KSP.VFX;
using System.Runtime.CompilerServices;
using UnityEngine;

public class VFXPartTestingHelper : MonoBehaviour
{
  public FXPartContextData PartData;
  public float Speed;
  private PQSFreeCam _pqsFreeCam;
  private PQS _pqs;
  public CelestialBodyData CbData;
  private bool _renderersEnabled;
  private MeshRenderer[] _renderers;
  private bool _posInitialized;
  private float _timer;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Initialize(CelestialBodyData cbData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetRendererVisibility(bool newValue) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ToggleRendererVisibility() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public VFXPartTestingHelper() => throw null;
}
