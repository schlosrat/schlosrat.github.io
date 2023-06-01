// Decompiled with JetBrains decompiler
// Type: AdvancedRagdoll
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class AdvancedRagdoll : MonoBehaviour
{
  public bool debug;
  public Transform ragdollRoot;
  public bool copyMaterials;
  public LayerMask groundLayer;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SynchRagdollIn(Transform src) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SynchRagdollOut(Transform dest) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CopyTransforms(Transform src, Transform dest) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void PoseToAnimation(Transform src, Transform dest) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void TransformToAnimationCurve(
    Transform src,
    Transform srcRoot,
    Transform dest,
    Transform destRoot,
    AnimationClip clip)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private string GetTransformPathToRoot(Transform t, Transform root) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CopyMaterials(Transform src, Transform dest) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AdvancedRagdoll() => throw null;
}
