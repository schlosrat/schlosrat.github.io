// Decompiled with JetBrains decompiler
// Type: KSP.Game.IInteractivePart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
