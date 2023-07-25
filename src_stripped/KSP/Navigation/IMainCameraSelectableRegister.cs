// Decompiled with JetBrains decompiler
// Type: KSP.Navigation.IMainCameraSelectableRegister
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using UnityEngine.UI;

namespace KSP.Navigation
{
  public interface IMainCameraSelectableRegister : INavElementRegister
  {
    bool AddMainCameraSelectable(Selectable item);

    bool RemoveSelectable(Selectable item);
  }
}
