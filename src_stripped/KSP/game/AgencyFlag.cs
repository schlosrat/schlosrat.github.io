// Decompiled with JetBrains decompiler
// Type: KSP.Game.AgencyFlag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
