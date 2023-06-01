// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.ModuleDataList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.Definitions
{
  [Serializable]
  public class ModuleDataList : DictionaryValueList<System.Type, ModuleData>
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryAddUnique<T>(T addData, out T resultData) where T : ModuleData => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetByType<T>(out T resultData) where T : class => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModuleDataList() => throw null;
  }
}
