// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.ImageDataEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding
{
  [Serializable]
  public class ImageDataEntry
  {
    public UpdateImageFlag UpdateFlags;
    [Tooltip("The string name of the enum")]
    public string EnumValue;
    public Sprite Sprite;
    public Color Color;

    public static ImageDataEntry Default
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ImageDataEntry() => throw null;
  }
}
