// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.CelestialBodyRing
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim.Definitions;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  [ExecuteInEditMode]
  [DisableCustomEditorBase]
  public class CelestialBodyRing : KerbalMonoBehaviour
  {
    public Plane ringPlanePhysics;
    public Vector3 ringPlanePhysicsPos;
    private CelestialBodyRingData _coreRingData;
    [HideInInspector]
    public float innerRadius;
    [HideInInspector]
    public float outerRadius;
    [HideInInspector]
    public Texture ringTexture;
    [HideInInspector]
    public float alphaEdge;
    [HideInInspector]
    public float scatteringMie;
    [HideInInspector]
    public float scatteringStrength;
    public Mesh mesh;
    [HideInInspector]
    public float innerRadiusMesh;
    [HideInInspector]
    public float outerRadiusMesh;
    [HideInInspector]
    public int segments;
    [HideInInspector]
    public int segmentDetail;
    [HideInInspector]
    public int radiusDetail;
    [HideInInspector]
    public float boundsShift;
    public Shader ringShader;
    [SerializeField]
    private CelestialBodyRingGroup _ringGroup;
    [SerializeField]
    private CelestialBodyRingMesh _ringMesh;
    private Texture _lightingTex;
    private Light _sourceLight;
    [SerializeField]
    private Camera _flightCamera;
    [SerializeField]
    private List<GameObject> _particleFields;
    [SerializeField]
    private List<CelestialBodyRingModel> models;
    [NonSerialized]
    private Material material;
    [SerializeField]
    private float _radius;
    [SerializeField]
    private float _scaleFactor;
    private bool _dependenciesSet;
    private SubscriptionHandle _handleFlightViewEntered;
    private SubscriptionHandle _handleFlightViewExited;

    public Plane ringPlane
    {
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(
      CelestialBodyRingGroup ringGroup,
      CelestialBodyRingData coreRingData,
      double bodyRadius)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DependentEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DependentDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RegisterEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSourceLightingValues(Light light) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFlightViewEntered(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFlightViewExited(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetLightingTex(Texture tex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetSourceLight(Light light) => throw null;

    [ContextMenu("Update Material")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void UpdateMaterial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableModels() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegenerateMesh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateMesh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateModels() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<GameObject> GetParticleFields() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddParticleField() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<CelestialBodyRingModel> GetModels() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyRingGroup GetRingGroup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private CelestialBodyRingModel GetOrAddModel(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Material CreateTempMaterial(string materialName, Shader shader) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyRing() => throw null;
  }
}
