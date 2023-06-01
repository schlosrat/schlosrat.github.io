// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.IModuleProperty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api;

namespace KSP.Sim.Definitions
{
  public interface IModuleProperty : IPropertyWritable, IProperty, IModuleDataContext
  {
    bool IsReadOnly { get; }

    string ContextKey { get; set; }

    ToStringDelegate ToStringDelegate { get; }
  }
}
