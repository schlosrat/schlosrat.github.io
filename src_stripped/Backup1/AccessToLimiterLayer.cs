// Decompiled with JetBrains decompiler
// Type: AccessToLimiterLayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
