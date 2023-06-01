// Decompiled with JetBrains decompiler
// Type: I2.Loc.EventCallback
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace I2.Loc
{
  [Serializable]
  public class EventCallback
  {
    public MonoBehaviour Target;
    public string MethodName;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(UnityEngine.Object Sender = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasCallback() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EventCallback() => throw null;
  }
}
