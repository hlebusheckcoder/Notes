﻿using Baza.Repository;
using Notes.Model;

namespace Notes.Repository
{
    public interface IMemoRepository : IRepository<Memo>
    {

        public Task<Memo> Remove(Memo item);
        public Task<Memo> Remove(int id);
        public Task<Memo> Recover(Memo item);
        public Task<Memo> Recover(int id);

        public Task Import(IEnumerable<Memo> items);
    }
}
