// using System;
// using System.Collections.Generic;

// namespace  her_care.Models
// {
//     public interface VetranRepository : IDisposable, IVetranRepository
//     {
//         // private VetranContext context;

//         // public VetranRepository(VetranRepositoryContext context)
//         // {
//         //     this.context = context;
//         // }

//         public IEnumerable<Vetran> GetVetrans()
//         {
//             return context.Vetrans.ToList();
//         }

//         public Student GetStudentByID(int id)
//         {
//             return context.Students.Find(id);
//         }

//         public void InsertStudent(Student student)
//         {
//             context.Students.Add(student);
//         }

//         public void DeleteStudent(int studentID)
//         {
//             Student student = context.Students.Find(studentID);
//             context.Students.Remove(student);
//         }

//         public void UpdateStudent(Student student)
//         {
//             context.Entry(student).State = EntityState.Modified;
//         }

//         public void Save()
//         {
//             context.SaveChanges();
//         }

//         private bool disposed = false;

//         protected virtual void Dispose(bool disposing)
//         {
//             if (!this.disposed)
//             {
//                 if (disposing)
//                 {
//                     context.Dispose();
//                 }
//             }
//             this.disposed = true;
//         }

//         public void Dispose()
//         {
//             Dispose(true);
//             GC.SuppressFinalize(this);
//         }
//     }
//     }
// }