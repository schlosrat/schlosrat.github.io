// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIValue_SAS_Wheel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace KSP.UI.Binding.Core
{
  public class UIValue_SAS_Wheel : KerbalMonoBehaviour
  {
    public List<UIValue_SAS_Wheel.GroupGameObj> groupGameObjects;
    public GameObject sasDefaultGameObject;
    public Transform currentImage;
    public ToggleExtended SAS_Enable;
    private int m_groupListIndex;
    private int m_groupListCount;
    private int m_frameCount;
    private GameObject m_ActiveToggle;
    private GameObject m_CorrectGameObject;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClosePanel(InputAction.CallbackContext obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ActiveChoseSAS(InputAction.CallbackContext obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateImagePos(bool isUp, int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SelectCorrectToggle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ActiveSASMode(ToggleExtended toggle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCorrectGameObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_SAS_Wheel() => throw null;

    [Serializable]
    public class GroupGameObj
    {
      public int objIndex;
      public List<GameObject> gameObjects;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public GroupGameObj() => throw null;
    }
  }
}
