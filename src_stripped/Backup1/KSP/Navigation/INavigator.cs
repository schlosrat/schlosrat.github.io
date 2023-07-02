// Decompiled with JetBrains decompiler
// Type: KSP.Navigation.INavigator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using UnityEngine.UI;

namespace KSP.Navigation
{
  public interface INavigator
  {
    INavigatable CurrentLayout { get; }

    bool Active { get; set; }

    bool Contains(INavigatable layout);

    void LoadLayout(INavigatable layout);

    void UnloadLayout(INavigatable layout);

    void UnloadAllLayout();

    void EnableInput(Navigator.InputType type);

    void DisableInput(Navigator.InputType type, bool forced = false);

    void Select(Selectable element);
  }
}
