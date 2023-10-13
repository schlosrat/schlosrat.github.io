// Decompiled with JetBrains decompiler
// Type: FXFadeByPressure
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
