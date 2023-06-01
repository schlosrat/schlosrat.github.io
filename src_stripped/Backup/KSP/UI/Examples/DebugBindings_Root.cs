// Decompiled with JetBrains decompiler
// Type: KSP.UI.Examples.DebugBindings_Root
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Examples
{
  public abstract class DebugBindings_Root : MonoBehaviour
  {
    [Header("Backend Changes")]
    [SerializeField]
    private bool autoChangeValues;
    [SerializeField]
    private float timeBetweenChanges;
    private float lastTime;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void OnQueuedValidate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void AutoChangeValueTick(float dt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<string> GetAllEnumValues<T>() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<string> GetAllEnumValues(System.Type enumType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected DebugBindings_Root() => throw null;
  }
}
