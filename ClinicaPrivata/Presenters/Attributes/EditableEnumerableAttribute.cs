using System;

namespace ClinicaPrivata.Presenter
{
    [AttributeUsage(AttributeTargets.Property)]
    public class EditableEnumerableAttribute : Attribute
    {
        private string _title;
        private int _width = 100;

        public EditableEnumerableAttribute(string title)
        {
            _title = title;
        }

        public string Title
        {
            get { return _title; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("String.IsNullOrEmpty(value)");
                _title = value;
            }
        }

        public int Width
        {
            get { return _width; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("value <= 0");
                _width = value;
            }
        }
    }
}
