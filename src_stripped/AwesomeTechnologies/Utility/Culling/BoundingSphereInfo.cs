﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.Culling.BoundingSphereInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using UnityEngine;

namespace AwesomeTechnologies.Utility.Culling
{
  public struct BoundingSphereInfo
  {
    public BoundingSphere BoundingSphere;
    public int CurrentDistanceBand;
    public int PreviousDistanceBand;
    public int Visibility;
    public int LastVisisbility;
    public int Enabled;
  }
}
