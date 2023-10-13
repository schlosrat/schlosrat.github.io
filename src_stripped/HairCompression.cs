// Decompiled with JetBrains decompiler
// Type: HairCompression
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class HairCompression : MonoBehaviour
{
  [FormerlySerializedAs("helmetCenter")]
  public Transform HelmetCenter;
  [SerializeField]
  [FormerlySerializedAs("helmetSupression")]
  [Range(0.0f, 1f)]
  private float _helmetSupression;
  [SerializeField]
  [Range(0.0f, 0.5f)]
  [FormerlySerializedAs("helmetRadius")]
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
