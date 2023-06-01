// Decompiled with JetBrains decompiler
// Type: UISkinning.UISkinData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
