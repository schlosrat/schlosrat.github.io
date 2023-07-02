// Decompiled with JetBrains decompiler
// Type: fx_emissive_toggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class fx_emissive_toggle : MonoBehaviour
{
  [SerializeField]
  private string shaderKeyword;
  [SerializeField]
  private float onMultiplier;
  [SerializeField]
  private float offMultiplier;
  private Renderer ourMesh;
  private bool toggleState;
  private Color originalColor;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Init() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public fx_emissive_toggle() => throw null;
}
