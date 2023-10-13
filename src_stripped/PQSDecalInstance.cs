// Decompiled with JetBrains decompiler
// Type: PQSDecalInstance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using AwesomeTechnologies.Utility;
using System.Runtime.CompilerServices;
using UnityEngine;

[AwesomeTechnologiesScriptOrder(20)]
[ExecuteInEditMode]
public class PQSDecalInstance : MonoBehaviour
{
  public Vector2 LatLong;
  public float Rotation;
  public float NormalRotation;
  public float Scale;
  public int MaxScale;
  public float MaxVerticalOffset;
  public float MinVerticalOffset;
  public float VerticalOffset;
  public PQSDecal PQSDecal;
  public string DecalInstanceID;
  public PQSDecalController PqsDecalController;
  public float HeightScale;
  public PQSDecalHeightBlendMode HeightBlendMode;
  [Range(-1f, 1f)]
  [SerializeField]
  public float HeightOffset;
  public PQSDecalAlphaFadeShape FadeShape;
  [Range(0.0f, 2f)]
  [SerializeField]
  public float FadeStrength;
  [Range(0.0f, 1f)]
  [SerializeField]
  public float AlbedoOpacity;
  [Range(0.0f, 1f)]
  [SerializeField]
  public float GradientOpacity;
  [Range(0.0f, 1f)]
  [SerializeField]
  public float NormalOpacity;
  public Color Tint;
  public PQSDecalBlendMode NormalBlend;
  public int SortOrder;
  public bool UseAlphaMask;
  public bool UseDecalTexturing;
  public bool UseTextureAlphaMask;
  public bool UseTextureHeightmapFade;
  [SerializeField]
  [Range(0.01f, 1.99f)]
  public float MaterialScaleFactor;
  public bool OverrideUseTextureAlphaMask;
  public bool OverrideUseTextureHeightmapFade;
  public bool OverrideUseAlphaMask;
  public bool OverrideUseDecalTexturing;
  public bool OverrideHeightScale;
  public bool OverrideHeightBlendMode;
  public bool OverrideHeightOffset;
  public bool OverrideFadeShape;
  public bool OverrideFadeStrength;
  public bool OverrideAlbedoOpacity;
  public bool OverrideNormalOpacity;
  public bool OverrideTint;
  public bool OverrideNormalBlend;
  public bool OverrideSortOrder;
  public bool OverrideMaterialScaleFactor;
  public bool OverrideGradientOpacity;
  private bool _updateNewDecal;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool IsDuplicate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Reset() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void DecalUpdated() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateDecalTransform(bool forPqs = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PQSDecalInstanceInfo GetInstanceInfo() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDrawGizmosSelected() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void DrawDecalCover(
    Vector2 polarPosition,
    Vector2 size,
    float sphereRadius,
    Vector3 spherePosition)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angles) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PQSDecalInstance() => throw null;
}
