// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.PartDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.Definitions
{
  public struct PartDefinition
  {
    [Obsolete("Use Guid instead")]
    public string key;
    public Guid Guid;
    public PartData Properties;
    public List<SerializedPartModule> Modules;
    public IGGuid OriginalPartId;

    [Obsolete("Please use Properties instead.")]
    public PartProperties properties
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }
  }
}
