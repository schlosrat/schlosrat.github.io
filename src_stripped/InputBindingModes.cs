// Decompiled with JetBrains decompiler
// Type: InputBindingModes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
