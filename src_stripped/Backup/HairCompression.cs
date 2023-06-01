// Decompiled with JetBrains decompiler
// Type: HairCompression
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class HairCompression : MonoBehaviour
{
  [FormerlySerializedAs("helmetCenter")]
  public Transform HelmetCenter;
  [Range(0.0f, 1f)]
  [FormerlySerializedAs("helmetSupression")]
  [SerializeField]
  private float _helmetSupression;
  [Range(0.0f, 0.5f)]
  [FormerlySerializedAs("helmetRadius")]
  [SerializeField]
  private float _helmetRadius;
  [SerializeField]
  [FormerlySerializedAs("hat")]
  private bool _hat;
  private Material[] _hairMaterials;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void InitializeHairCompressionShaderValues() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateHairCompression() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public HairCompression() => throw null;
}
