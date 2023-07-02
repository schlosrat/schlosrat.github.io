// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.ImageDataEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
