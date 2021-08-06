using System;
using System.Collections.Generic;

namespace ForumApp.Core.Interfaces
{
    public interface IJsonPlaceHolderService<T>
    {
        public T Get();
        public List<T> GetAll();
    }
}
