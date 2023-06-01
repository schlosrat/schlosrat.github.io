// Decompiled with JetBrains decompiler
// Type: AccessToLimiterLayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class AccessToLimiterLayer : MonoBehaviour
{
  [Tooltip("Index of the layer that will be updated.\nIndex = it's spot in the layer list, from top=0 to bottom.")]
  public int layerIndexToUpdate;
  [SerializeField]
  private Animator animator;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetLayerWeight(float newWeight) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public float GetLayerWeight() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AccessToLimiterLayer() => throw null;
}
