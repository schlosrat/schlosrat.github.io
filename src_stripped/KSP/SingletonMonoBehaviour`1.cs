// Decompiled with JetBrains decompiler
// Type: KSP.SingletonMonoBehaviour`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
