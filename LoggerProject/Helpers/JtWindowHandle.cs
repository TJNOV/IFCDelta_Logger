﻿using System;
using System.Diagnostics;
using System.Windows.Interop;

namespace Helpers
  {
  /// <summary>
  /// Wrapper class for converting 
  /// IntPtr to IWin32Window.
  /// </summary>
  public class JtWindowHandle : IWin32Window
    {
    IntPtr _hwnd;

    public JtWindowHandle(IntPtr h)
      {
      Debug.Assert(IntPtr.Zero != h,
        "expected non-null window handle");

      _hwnd = h;
      }

    public IntPtr Handle
      {
      get
        {
        return _hwnd;
        }
      }
    }
  }