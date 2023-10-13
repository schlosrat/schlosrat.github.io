// Decompiled with JetBrains decompiler
// Type: BasePropertyWatcherBinding
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
