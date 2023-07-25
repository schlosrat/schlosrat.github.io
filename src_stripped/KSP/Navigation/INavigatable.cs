// Decompiled with JetBrains decompiler
// Type: KSP.Navigation.INavigatable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
