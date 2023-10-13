// Decompiled with JetBrains decompiler
// Type: TransformExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class TransformExtension
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void NestToParent(
    this Transform t,
    Transform newParent,
    bool keepRelativeLocalScale = false)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static Transform FindChildEx(this Transform parent, string childName, bool includeParent = true) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static Transform FindChildRecursive(this Transform parent, string childName) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static List<Transform> FindChildren(
    this Transform parent,
    string childName,
    bool includeParent = true)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void FindChildrenRecursive(
    Transform parent,
    string childName,
    List<Transform> results)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static List<Transform> FindChildrenIfNameContains(
    this Transform parent,
    string nameContains,
    bool caseSensitive = true)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void FindChildrenRecursiveIfNameContains(
    Transform parent,
    string nameContains,
    bool caseSensitive,
    List<Transform> results)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool IsChildInHierarchy(this Transform parent, Transform child) => throw null;
}
