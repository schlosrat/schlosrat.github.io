// Decompiled with JetBrains decompiler
// Type: KSP.Map.Map3DFocusItemIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Map
{
  [RequireComponent(typeof (SpriteRenderer))]
  public class Map3DFocusItemIcon : KerbalMonoBehaviour
  {
    [SerializeField]
    private Sprite defaultIcon;
    [SerializeField]
    private List<Map3DFocusItemIcon.IconForType> iconLookup;
    private SpriteRenderer iconImage;
    private Camera billboardCam;

    public SpriteRenderer IconImage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Configure(MapItemType type, Camera billboardCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Map3DFocusItemIcon() => throw null;

    [Serializable]
    public class IconForType
    {
      public MapItemType type;
      public Sprite icon;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public IconForType() => throw null;
    }
  }
}
