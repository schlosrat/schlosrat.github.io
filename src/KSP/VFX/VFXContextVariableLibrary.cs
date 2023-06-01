// Decompiled with JetBrains decompiler
// Type: KSP.VFX.VFXContextVariableLibrary
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.VFX
{
  public static class VFXContextVariableLibrary
  {
    public static VFXContextVariable[] VFXContextVariables;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static VFXContextVariable GetContextVariable(int index, VFXContextVariableType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<VFXContextVariable> GetContextVariablesForType(VFXContextVariableType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetContextVariableIndexForType(VFXContextVariableType type, string id) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string[] GetContextVariableNamesForType(VFXContextVariableType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static VFXContextVariableLibrary() => throw null;
  }
}
