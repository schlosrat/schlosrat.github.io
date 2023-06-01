// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.Wind.WindControllerSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.Common;
using System;
using System.Runtime.CompilerServices;

namespace AwesomeTechnologies.VegetationSystem.Wind
{
  [Serializable]
  public class WindControllerSettings : BaseControllerSettings
  {
    public string Heading;
    public string Description;
    public string WindControlerID;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WindControllerSettings() => throw null;
  }
}
