// Decompiled with JetBrains decompiler
// Type: KSP.Game.AgencyFlag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  [Serializable]
  public class AgencyFlag
  {
    public string FlagName;
    public Sprite FlagIcon;
    public Color PrimaryColor;
    public Color SecondaryColor;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AgencyFlag() => throw null;
  }
}
