// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.SerializedModuleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.Definitions
{
  [Serializable]
  public struct SerializedModuleData
  {
    public string Name;
    [Obsolete("This is only used for the conversion of older persistent data to 0.3 and above")]
    public Type ModuleType;
    public Type DataType;
    [Obsolete("Deprecated. Use DataObject instead")]
    public string Data;
    public ModuleData DataObject;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedModuleData(ModuleData moduleData) => throw null;
  }
}
