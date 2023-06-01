// Decompiled with JetBrains decompiler
// Type: VersioningBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Obsolete("No replacement yet")]
public abstract class VersioningBase : MonoBehaviour
{
  protected static VersioningBase instance;

  public static VersioningBase Instance
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected abstract void OnAwake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string GetVersionString() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected abstract string GetVersion() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected VersioningBase() => throw null;
}
