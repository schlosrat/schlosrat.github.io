// Decompiled with JetBrains decompiler
// Type: KSP.Navigation.INavigatable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KSP.Navigation
{
  public interface INavigatable
  {
    Selectable CurrentElement { get; set; }

    bool Focused { get; set; }

    bool Active { get; set; }

    void UnloadComplete();

    bool SelectElementAt(MoveDirection direction);

    void Quit();
  }
}
