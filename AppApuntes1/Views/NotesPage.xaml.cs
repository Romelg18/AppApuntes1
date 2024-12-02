using AppApuntes1.Models;
using System.Collections.ObjectModel;

namespace AppApuntes1.Views
{
    public partial class NotesPage : ContentPage
    {
        public ObservableCollection<Note> Notes { get; set; } = new ObservableCollection<Note>();

        public NotesPage()
        {
            InitializeComponent();
            notesListView.ItemsSource = Notes;
        }

        private void OnSaveNoteClicked(object sender, EventArgs e)
        {
            var newNote = new Note
            {
                Title = noteTitleEntry.Text,
                Content = noteContentEditor.Text
            };
            Notes.Add(newNote);

            noteTitleEntry.Text = string.Empty;
            noteContentEditor.Text = string.Empty;
        }
    }
}
