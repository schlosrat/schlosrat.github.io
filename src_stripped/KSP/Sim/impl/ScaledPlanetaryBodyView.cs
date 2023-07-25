// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ScaledPlanetaryBodyView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class ScaledPlanetaryBodyView : KerbalMonoBehaviour
  {
    private double baseSizeFactor;
    private double invBaseSizeFactor;
    private CelestialBodyComponent _model;
    private MeshRenderer _renderer;
    private Material _material;
    private bool _isModelDirty;

    public MeshRenderer Renderer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Material Material
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CelestialBodyComponent Model
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculateNormalizationFactorFromCollider() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScaledPlanetaryBodyView() => throw null;
  }
}
