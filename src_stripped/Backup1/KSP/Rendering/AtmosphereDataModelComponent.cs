// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.AtmosphereDataModelComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Rendering.Planets;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  public class AtmosphereDataModelComponent : KerbalMonoBehaviour
  {
    [SerializeField]
    private string _modelPath;
    [SerializeField]
    private string _atmosphereModelKey;
    [SerializeField]
    private string _planetName;
    private AtmosphereScatterManager _atmosphereManagerRef;
    private AtmosphereModel _model;
    private Light _starLight;
    private bool _inMap;
    private Material _innerMaterial;
    [SerializeField]
    private MeshRenderer _innerMeshRenderer;
    private Material _outerMaterial;
    [SerializeField]
    private MeshRenderer _outerMeshRenderer;

    public string AtmosphereModelKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string PlanetName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(AtmosphereScatterManager manager, bool inMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTransition(float transition, float ditherScale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPreRenderObserverCubemap(float transition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPostRenderObserverCubemap(float transition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPreRenderCelestialBodyCubemap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPostRenderCelestialBodyCubemap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateMaterial(Material mat, bool applyViewSettings) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableMeshRenderer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisableMeshRenderer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasModelReference() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetModelReference(AtmosphereModel model) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetOuterMeshRenderer(out MeshRenderer meshRenderer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupInnerAtmosphereMesh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupOuterAtmosphereMesh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FlightViewUpdate(Material mat) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MapViewUpdate(Material mat) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ScaleAtmosphereMesh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetHeight() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AtmosphereDataModelComponent() => throw null;
  }
}
