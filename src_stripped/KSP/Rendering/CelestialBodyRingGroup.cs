// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.CelestialBodyRingGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim.Definitions;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  [ExecuteInEditMode]
  public class CelestialBodyRingGroup : KerbalMonoBehaviour
  {
    [SerializeField]
    private bool _coreDataFound;
    [SerializeField]
    private float _coreBodyRadius;
    [SerializeField]
    public float shadowThickness;
    [SerializeField]
    public float horizontalPadding;
    [SerializeField]
    public float verticalPadding;
    [SerializeField]
    public Color ambientDay;
    [SerializeField]
    public Color ambientNight;
    [SerializeField]
    private List<CelestialBodyRingData> _coreRingData;
    [SerializeField]
    private List<CelestialBodyRing> _rings;
    [SerializeField]
    private List<bool> _editorFoldouts;
    [SerializeField]
    public float alphaNearFlight;
    [SerializeField]
    public float alphaFarFlight;
    [SerializeField]
    public float alphaNearMap;
    [SerializeField]
    public float alphaFarMap;
    public bool isMapItem;
    [SerializeField]
    private Light _sourceLight;
    private CelestialBodyRingLighting lightingTexGenerator;
    public Texture lightingTex;
    [SerializeField]
    public int width;
    [SerializeField]
    public UnityEngine.TextureFormat format;
    [SerializeField]
    public float frontPower;
    [SerializeField]
    public float backPower;
    [SerializeField]
    public float backStrength;
    [SerializeField]
    public float baseStrength;
    private Vector3 _ringBounds;
    private List<MeshRenderer> _ringRenderers;
    public CelestialBodyRingSimHelper RingHelper;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PrevisAwake(PrevisGameInstance previsGame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetCoreCelestialBodyData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<CelestialBodyRing> GetRings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateRingsInGroup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddNewRing(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveGroupAtIndex(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddParticleFieldAtIndex(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateAllMaterials() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateMaterialAtIndex(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegenerateMeshAtIndex(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetLightingTexGenerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLightingTexForRings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSourceLight(Light light) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetBounds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<MeshRenderer> GetRenderers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyRingGroup() => throw null;
  }
}
