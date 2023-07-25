// Decompiled with JetBrains decompiler
// Type: KSP.OAB.VisualCollection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.OAB
{
  [Serializable]
  public struct VisualCollection
  {
    [SerializeField]
    public Image stateImage;
    [HideInInspector]
    public Color stateDefaultColor;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDefaultFromImage() => throw null;
  }
}
