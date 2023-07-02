// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.Data.IDemoView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.Generic;

namespace KSP.Iteration.Data
{
  public interface IDemoView
  {
    IProperty<bool> MapIsEnabled { get; }

    void ToggleMapIsEnabled();

    void SetMapIsEnabled(bool value);

    IProperty<IDemoVessel> ActiveVessel { get; }
  }
}
