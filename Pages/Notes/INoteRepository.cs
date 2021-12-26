using System;
using System.Collections.Generic;

namespace Notes.Pages.Notes
{
    public interface INoteRepository
    {
        IEnumerable<NoteModel> GetAll();
        void Save(NoteModel noteModel);
        void Delete(NoteModel noteModel);

    }
}