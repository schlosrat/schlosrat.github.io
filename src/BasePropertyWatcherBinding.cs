// Decompiled with JetBrains decompiler
// Type: BasePropertyWatcherBinding
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class BasePropertyWatcherBinding
{
  [HideInInspector]
  public string Name;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public virtual void Subscribe() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public virtual void Unsubscribe() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public virtual void PollPropertyWatcher() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public BasePropertyWatcherBinding() => throw null;
}
