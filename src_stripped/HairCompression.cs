// Decompiled with JetBrains decompiler
// Type: HairCompression
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class HairCompression : MonoBehaviour
{
  [FormerlySerializedAs("helmetCenter")]
  public Transform HelmetCenter;
  [SerializeField]
  [Range(0.0f, 1f)]
  [FormerlySerializedAs("helmetSupression")]
  private float _helmetSupression;
  [Range(0.0f, 0.5f)]
  [FormerlySerializedAs("helmetRadius")]
  [SerializeField]
  private float _helmetRadius;
  [FormerlySerializedAs("hat")]
  [SerializeField]
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
