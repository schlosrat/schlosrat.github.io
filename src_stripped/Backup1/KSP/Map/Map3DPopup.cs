// Decompiled with JetBrains decompiler
// Type: KSP.Map.Map3DPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Map
{
  public class Map3DPopup : UI3DTrackingObject
  {
    [SerializeField]
    private Image icon;
    [SerializeField]
    private TextMeshProUGUI title;
    [SerializeField]
    private GameObject flavorTextContainer;
    [SerializeField]
    private TextMeshProUGUI flavorText;
    [Space]
    [SerializeField]
    private List<Map3DPopup.IconPair> iconOptions;
    private Map3DTooltipDetailLine[] detailLines;
    private static string translatedVelocity;
    private static string translatedAltitude;
    private static string translatedAssemblies;
    private static string translatedNone;
    private static string translatedBeacon;
    private static string translatedWaypoint;
    private static string translatedUnknownObject;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetData(Canvas canvas, MapItem item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetDetailLine(int lineIndex, string label, string value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HideAllDetailLines() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Sprite GetIconFor(MapItemType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PerformSquish(Map3DTooltips manager) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator Squish(Action squishFinished) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Map3DPopup() => throw null;

    [Serializable]
    public class IconPair
    {
      public MapItemType type;
      public Sprite sprite;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public IconPair() => throw null;
    }
  }
}
