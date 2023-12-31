﻿using System;
using Windows.UI.Xaml.Controls;

namespace Tutorial.Ui.DIItems
{
    public class FrameContainer : IFrameContainer
    {
        private Frame _mainFrame = null;

        public Frame MainFrame
        {
            get => _mainFrame == null ? new Frame() : _mainFrame;
        }

        public void InstallFrame(Frame frame)
        {
            if(_mainFrame != null)
            {
                throw new InvalidOperationException("Frame is already initialized");
            }

            _mainFrame = frame;
        }
    }
}
