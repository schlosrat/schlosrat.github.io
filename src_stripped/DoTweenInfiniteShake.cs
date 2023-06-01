// Decompiled with JetBrains decompiler
// Type: DoTweenInfiniteShake
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class DoTweenInfiniteShake : MonoBehaviour
{
  [SerializeField]
  private float duration;
  [SerializeField]
  private float strength;
  [Range(0.0f, 50f)]
  [SerializeField]
  private int vibrato;
  [SerializeField]
  [Range(0.0f, 180f)]
  private float random;
  [SerializeField]
  private bool snap;
  [SerializeField]
  private bool fadeOut;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DoTweenInfiniteShake() => throw null;
}
