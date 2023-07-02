// Decompiled with JetBrains decompiler
// Type: KSP.VFX.VFXContextVariableLibrary
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
