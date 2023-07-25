// Decompiled with JetBrains decompiler
// Type: KSP.Navigation.IQuickNavRegister
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
