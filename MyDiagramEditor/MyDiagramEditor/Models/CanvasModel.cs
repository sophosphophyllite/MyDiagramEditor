﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiagramEditor.Models
{
    public class CanvasModel : PropertyChangedBase
    {
        private string _creator = "";
        private double _width = 0;
        private double _height = 0;
        private string _name = "";
        private string _protection = "";
        private string _privacy = "";
        private string _password = "";

        public CanvasModel() { }

        public string Creator
        {
            get { return _creator; }
            set
            {
                if (_creator != value)
                {
                    _creator = value;
                    NotifyOfPropertyChange(() => Creator);
                }
            }
        }
        public double Width
        {
            get { return _width; }
            set
            {
                if (_width != value)
                {
                    _width = value;
                    NotifyOfPropertyChange(() => Width);
                }
            }
        }
        public double Height
        {
            get { return _height; }
            set
            {
                if (_height != value)
                {
                    _height = value;
                    NotifyOfPropertyChange(() => Height);
                }
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    NotifyOfPropertyChange(() => Name);
                }
            }
        }
        public string Protection
        {
            get { return _protection; }
            set
            {
                if (_protection != value)
                {
                    _protection = value;
                    NotifyOfPropertyChange(() => Protection);
                }
            }
        }
        public string Privacy
        {
            get { return _privacy; }
            set
            {
                if (_privacy != value)
                {
                    _privacy = value;
                    NotifyOfPropertyChange(() => Privacy);
                }
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    NotifyOfPropertyChange(() => Password);
                }
            }
        }
    }
}
