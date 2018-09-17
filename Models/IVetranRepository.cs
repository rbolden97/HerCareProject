using System;
using System.Collections.Generic;

namespace  her_care.Models
{
    public interface IVetranRepository : IDisposable
    {
        IEnumerable<Vetran> GetVetrans();
        Vetran GetVetranByID(int vetranId);
        void InsertVetran(Vetran vetran);
        void DeleteVetran(int vetranID);
        void UpdateVetran(Vetran vetran);
        void Save();
    }
}