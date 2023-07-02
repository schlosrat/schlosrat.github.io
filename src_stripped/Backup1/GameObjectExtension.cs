// Decompiled with JetBrains decompiler
// Type: GameObjectExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public static class GameObjectExtension
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  public static T GetComponentCached<T>(this GameObject gameobject, ref T cache) where T : Component => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static T GetComponentCached<T>(this Component component, ref T cache) where T : Component => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static T AddOrGetComponent<T>(this GameObject obj) where T : Component => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static T GetComponentOnParent<T>(this GameObject obj) where T : Component => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static Component GetComponentOnParent(this GameObject obj, string type) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static T GetComponentInParent<T>(this Component component, bool includeInactive) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static T GetComponentInParent<T>(this GameObject gameObject, bool includeInactive) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static T GetComponentUpwards<T>(this GameObject gameObject) where T : Component => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static int GetComponentIndex<T>(this GameObject host, T tgt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static GameObject GetChild(this GameObject obj, string childName) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetLayerRecursive(this GameObject obj, int layer, int ignoreLayersMask = -1) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetTagsRecursive(this GameObject obj, string tag, params string[] ignoreTags) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void DestroyGameObject(this GameObject obj) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void DestroyGameObjectImmediate(this GameObject obj) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetDebugName(this Object @this, string name) => throw null;
}
