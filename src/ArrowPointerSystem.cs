// Decompiled with JetBrains decompiler
// Type: ArrowPointerSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Obsolete]
public class ArrowPointerSystem : MonoBehaviour
{
  public Material material;
  public float baseSize;

  [Obsolete("Singleton!", true)]
  public static ArrowPointerSystem Instance
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  public static Material Material
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static float BaseSize
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ArrowPointerSystem() => throw null;
}
