// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.LightLOD
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  [RequireComponent(typeof (Light))]
  public class LightLOD : MonoBehaviour
  {
    public bool Enabled;
    [SerializeField]
    private Transform _transform;
    [SerializeField]
    private Light _light;
    [SerializeField]
    private float _lightIntensity;
    [SerializeField]
    private LightShadows _shadowType;
    [SerializeField]
    private float _shadowStrength;
    [Space]
    [Range(0.0f, 1f)]
    [SerializeField]
    private float _lod1FadeWidth;
    [SerializeField]
    private float _lod1Distance;
    private float _lod1DistanceSqr;
    [Range(0.0f, 1f)]
    [SerializeField]
    private float _lod2FadeWidth;
    [SerializeField]
    private float _lod2Distance;
    private float _lod2DistanceSqr;
    [SerializeField]
    private int _lodIndex;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLod1DistanceSqr() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLod2DistanceSqr() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CacheReferences() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetLightPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateLightLod(float distanceSqr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLodIndex(int index, bool forceUpdate = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateShadowStrength(float distanceSqr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateLightIntensity(float distanceSqr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LightLOD() => throw null;
  }
}
