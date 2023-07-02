// Decompiled with JetBrains decompiler
// Type: KSP.OAB.OABEditorPartCategory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;

namespace KSP.OAB
{
  [Serializable]
  public enum OABEditorPartCategory
  {
    VAB = 0,
    BAE = 1,
    ALL = 2,
    NONE = 3,
    VAB_ORBITAL = 10, // 0x0000000A
    VAB_TERRESTRIAL = 11, // 0x0000000B
    BAE_ORBITAL = 20, // 0x00000014
    BAE_TERRESTRIAL = 21, // 0x00000015
  }
}
