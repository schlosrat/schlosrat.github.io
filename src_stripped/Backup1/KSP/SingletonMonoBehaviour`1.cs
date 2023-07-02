// Decompiled with JetBrains decompiler
// Type: KSP.SingletonMonoBehaviour`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP
{
  [Obsolete("Exposes instance via singleton which is obsolete in most cases", true)]
  public class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
  {
    private static T fetch;

    [Obsolete("Exposes instance via singleton which is obsolete in most cases", true)]
    public static T Fetch
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SingletonMonoBehaviour() => throw null;
  }
}
