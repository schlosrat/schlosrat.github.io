// Decompiled with JetBrains decompiler
// Type: KSP.OAB.IObjectAssemblyTool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;

namespace KSP.OAB
{
  public interface IObjectAssemblyTool : IDisposable
  {
    void Initialize();

    void PrimaryActionClick();

    void SecondaryActionUp();

    void OnUserCreatedPart(IObjectAssemblyPart part);

    void SetupCursorForTool();

    void Reset();
  }
}
