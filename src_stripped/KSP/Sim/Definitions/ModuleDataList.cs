// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.ModuleDataList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
