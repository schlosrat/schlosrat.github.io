// Decompiled with JetBrains decompiler
// Type: AdvancedRagdoll
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
