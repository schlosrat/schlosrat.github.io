// Decompiled with JetBrains decompiler
// Type: KSP.ModularCamera.ICameraInputProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using UnityEngine;

namespace KSP.ModularCamera
{
  public interface ICameraInputProvider
  {
    void HandleMouseDragLocks(ICameraDriver driver);

    void PassInputsToDriver(ICameraDriver driver);

    void ClearLastInputs();

    void ClearLastMoveInput();

    void ClearLastDragInput();

    void ClearLastScrollInput();

    Vector3 GetRawMoveInput();

    Vector2 GetRawDragInput();

    float GetRawScrollInput();

    void MouseLock(KeyCode toLock);

    void MouseUnlock();
  }
}
