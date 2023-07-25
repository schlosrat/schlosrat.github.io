// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.SerializedModuleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
