// Decompiled with JetBrains decompiler
// Type: FXFadeByPressure
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FXFadeByPressure : MonoBehaviour
{
  public List<Color> colors;
  public List<float> alpha;
  public float maxAlpha;
  public float airDensity;
  public float fadeStartDns;
  public float fadeEndDns;
  private Color[] modifiedColors;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public FXFadeByPressure() => throw null;
}
