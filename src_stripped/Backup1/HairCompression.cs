// Decompiled with JetBrains decompiler
// Type: HairCompression
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class HairCompression : MonoBehaviour
{
  [FormerlySerializedAs("helmetCenter")]
  public Transform HelmetCenter;
  [FormerlySerializedAs("helmetSupression")]
  [Range(0.0f, 1f)]
  [SerializeField]
  private float _helmetSupression;
  [FormerlySerializedAs("helmetRadius")]
  [Range(0.0f, 0.5f)]
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
