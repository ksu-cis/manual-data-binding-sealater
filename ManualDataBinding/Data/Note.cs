using System;

namespace ManualDataBinding.Data
{
    /// <summary>
    /// A class representing a note
    /// </summary>
    public class Note
    {
        /// <summary>
        /// Note changed event
        /// </summary>
        public event EventHandler NoteChanged;


        private string _title = DateTime.Now.ToString();
        /// <summary>
        /// The title of the Note
        /// </summary>
        public string Title
        {
            get => _title;
            set
            {
                if (_title == value) return;

                _title = value;
                NoteChanged?.Invoke(this, new EventArgs());
            }
        }

        private string _body = "";
        /// <summary>
        /// The text of the note
        /// </summary>
        public string Body
        {
            get => _body;
            set
            {
                if (_body == value) return;

                _body = value;
                NoteChanged?.Invoke(this, new EventArgs());
            }
        }
    }
}
