// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.Wind.IWindController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem.Wind
{
  public interface IWindController
  {
    string WindControlerID { get; }

    WindControllerSettings Settings { get; set; }

    WindControllerSettings CreateDefaultSettings();

    void RefreshSettings();

    void UpdateWind(WindZone windZone, float windSpeedFactor);
  }
}
