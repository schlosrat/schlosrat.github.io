// Decompiled with JetBrains decompiler
// Type: DynamicMeshCollisionGeneratorDemo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DynamicMeshCollisionGeneratorDemo : MonoBehaviour
{
  public DynamicMeshCollisionGeneratorDemo.MeshDestinationPair[] meshPairs;
  private List<GameObject> generatedGameObjects;
  private List<GameObject> sourceMeshesCurrentlyManaged;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void GenerateStaticMeshesAndCollision() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ToggleSkinnedMeshes(bool showSkinnedMeshes) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void HACK_MIRRORDUPLICATEWINGFORDEMO() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DynamicMeshCollisionGeneratorDemo() => throw null;

  [Serializable]
  public class MeshDestinationPair
  {
    public SkinnedMeshRenderer[] sourceMeshes;
    public Transform targetAttachBone;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MeshDestinationPair() => throw null;
  }
}
