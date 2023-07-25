// Decompiled with JetBrains decompiler
// Type: KSP.Game.IInteractivePart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
