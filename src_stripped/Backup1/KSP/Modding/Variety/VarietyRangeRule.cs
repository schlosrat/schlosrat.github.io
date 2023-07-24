﻿// Decompiled with JetBrains decompiler
// Type: KSP.Modding.Variety.VarietyRangeRule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Modding.Variety
{
  public struct VarietyRangeRule
  {
    public string name;
    public Type valueType;
    public VarietyRangeType varietyRangeType;
    public float probabilityOfEmpty;
    public object min;
    public object max;
    public object overrideValue;
    public List<object> specificOptions;
    public string subcategoryKey;
    public string attachToName;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static VarietyRangeRule Defaults() => throw null;
  }
}