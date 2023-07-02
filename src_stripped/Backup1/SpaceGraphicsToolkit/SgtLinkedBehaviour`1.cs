// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtLinkedBehaviour`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  public abstract class SgtLinkedBehaviour<T> : MonoBehaviour where T : SgtLinkedBehaviour<T>
  {
    [NonSerialized]
    public static T FirstInstance;
    [NonSerialized]
    public static int InstanceCount;
    [NonSerialized]
    public T PrevInstance;
    [NonSerialized]
    public T NextInstance;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected SgtLinkedBehaviour() => throw null;
  }
}
