// Decompiled with JetBrains decompiler
// Type: KSP.Navigation.IQuickNavRegister
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KSP.Navigation
{
  public interface IQuickNavRegister : INavElementRegister
  {
    bool AddAccess(
      MoveDirection direction,
      Selectable explicitSelectable = null,
      RectTransform selectionRect = null,
      SelectPoint startPoint = SelectPoint.Up,
      ADynamicNavLayout layout = null);

    bool RemoveAccess(MoveDirection direction, RectTransform selectionRect);

    bool RemoveAccess(MoveDirection direction, Selectable explicitSelectable);
  }
}
