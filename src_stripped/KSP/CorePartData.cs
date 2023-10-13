// Decompiled with JetBrains decompiler
// Type: KSP.CorePartData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim.Definitions;
using MoonSharp.Interpreter;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP
{
  [DisallowMultipleComponent]
  public class CorePartData : MonoBehaviour
  {
    [SerializeField]
    private PartCore core;
    [HideInInspector]
    [NonSerialized]
    private static Script _legacyEnv;

    public PartData Data
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public PartCore Core
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private static Script legacyEnv
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Dictionary<string, object>> EmitLegacyModuleFormat(string legacyModules) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CorePartData() => throw null;
  }
}
