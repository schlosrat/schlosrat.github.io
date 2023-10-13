// Decompiled with JetBrains decompiler
// Type: VersioningBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
