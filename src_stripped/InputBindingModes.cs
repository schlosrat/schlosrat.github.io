// Decompiled with JetBrains decompiler
// Type: InputBindingModes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;

[Flags]
public enum InputBindingModes
{
  None = 0,
  Staging = 1,
  Docking_Translation = 2,
  Docking_Rotation = 4,
  RotationModes = Docking_Rotation | Staging, // 0x00000005
  DockingModes = Docking_Rotation | Docking_Translation, // 0x00000006
  Any = -1, // 0xFFFFFFFF
}
