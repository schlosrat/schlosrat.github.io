// Decompiled with JetBrains decompiler
// Type: KSP.Game.IInteractivePart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.impl;

namespace KSP.Game
{
  public interface IInteractivePart
  {
    string GetCategoryName();

    string GetDisplayName();

    void DestroyInteractivePart();

    string Name { get; }

    IGGuid Guid { get; }

    DictionaryValueList<System.Type, IPartModule> Modules { get; }

    PartCategories Category { get; }
  }
}
