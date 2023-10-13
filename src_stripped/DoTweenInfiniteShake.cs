// Decompiled with JetBrains decompiler
// Type: DoTweenInfiniteShake
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
