// Decompiled with JetBrains decompiler
// Type: I2.Loc.EventCallback
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
