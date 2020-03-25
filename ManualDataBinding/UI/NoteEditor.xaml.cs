using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ManualDataBinding.Data;

namespace ManualDataBinding.UI
{
    /// <summary>
    /// Interaction logic for NoteEditor.xaml
    /// </summary>
    public partial class NoteEditor : UserControl
    {
        private Note _note;
        /// <summary>
        /// The Note that we will be editting on this control
        /// </summary>
        public Note Note
        {
            get => _note;
            set
            {
                if (_note != null) _note.NoteChanged -= OnNoteChanged;
                _note = value;
                if (_note != null)
                {
                    _note.NoteChanged += OnNoteChanged;
                    OnNoteChanged(_note, new EventArgs());
                }
            }
        }

        public NoteEditor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler to update Controls when Note is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnNoteChanged(object sender, EventArgs e)
        {
            if (Note == null) return;

            Title.Text = Note.Title;
            Body.Text = Note.Body;
        }

        /// <summary>
        /// Event handler to update note Title
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnTitleChanged(object sender, TextChangedEventArgs e)
        {
            Note.Title = Title.Text;
        }

        /// <summary>
        /// Event handler to update note Body
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnBodyChanged(object sender, TextChangedEventArgs e)
        {
            Note.Body = Body.Text;
        }
    }
}
