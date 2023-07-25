// Decompiled with JetBrains decompiler
// Type: VersioningBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
