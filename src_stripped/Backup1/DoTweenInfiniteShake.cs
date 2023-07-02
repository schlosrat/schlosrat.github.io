// Decompiled with JetBrains decompiler
// Type: DoTweenInfiniteShake
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
  [Range(0.0f, 180f)]
  [SerializeField]
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
