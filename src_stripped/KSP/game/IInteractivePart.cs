// Decompiled with JetBrains decompiler
// Type: KSP.Game.IInteractivePart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
