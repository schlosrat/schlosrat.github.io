// Decompiled with JetBrains decompiler
// Type: UISkinning.UISkinData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UISkinning
{
  [CreateAssetMenu(menuName = "KSP/UI Skin Data")]
  public class UISkinData : ScriptableObject
  {
    public List<UISkinData.uiSkinDataProperties> uiSkinDataObjects;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UISkinData() => throw null;

    [Serializable]
    public class uiSkinDataProperties
    {
      public string name;
      public UISkinData.uiSkinDataProperties.uiTagType uiTag;
      public GameObject uiButton;
      public GameObject uiImage;
      public GameObject uiInputField;
      public GameObject uiScrollbar;
      public GameObject uiSlider;
      public GameObject uiText;
      public GameObject uiToggle;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public uiSkinDataProperties() => throw null;

      public enum uiTagType
      {
        UI_FLIGHT_HUD,
        UI_VAB,
      }
    }
  }
}
