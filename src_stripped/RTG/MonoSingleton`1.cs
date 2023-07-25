// Decompiled with JetBrains decompiler
// Type: RTG.MonoSingleton`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
  {
    private static object _singletonLock;
    private static T _instance;

    public static T Get
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MonoSingleton() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static MonoSingleton() => throw null;
  }
}
