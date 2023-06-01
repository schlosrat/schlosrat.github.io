// Decompiled with JetBrains decompiler
// Type: KSP.Navigation.IQuickNavRegister
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
