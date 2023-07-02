// Decompiled with JetBrains decompiler
// Type: InputBindingModes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
