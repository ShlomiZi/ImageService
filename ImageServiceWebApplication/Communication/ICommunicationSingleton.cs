﻿using ImageService.Modal;
using System;

namespace ImageServiceWebApplication.Communication
{
    interface ICommunicationSingleton
    {
        event EventHandler<CommandRecievedEventArgs> InMessage;
        bool IsConnected { get; set; }
        void Write(CommandRecievedEventArgs command);
        void Read();
        void Disconnect();
    }
}