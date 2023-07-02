// Decompiled with JetBrains decompiler
// Type: ParticleColliderLaunchSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
