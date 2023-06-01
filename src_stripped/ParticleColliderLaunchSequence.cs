// Decompiled with JetBrains decompiler
// Type: ParticleColliderLaunchSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ParticleColliderLaunchSequence : MonoBehaviour
{
  public Transform[] chaosSpinners;
  public float spinChaos;
  public float chaosDrop;
  public float chaosDropTime;
  public Transform[] chaosJudders;
  public float judderChaos;
  public float totalTime;
  private Vector3[,] chaosSpinnerPositions;
  private Vector3[] chaosJudderAxis;
  private Collider[] colliders;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Reset() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator LaunchSequence() => throw null;

  [ContextMenu("Go For Launch")]
  [MethodImpl(MethodImplOptions.NoInlining)]
  public void GoForLaunch() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ParticleColliderLaunchSequence() => throw null;
}
