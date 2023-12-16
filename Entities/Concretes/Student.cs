using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

public class Student : Entity<int>
{
    public int UserId { get; set; }
    public int StudentNumber { get; set; }
    public User User { get; set; }
    public Classroom Classroom { get; set; } // -kaldırılacak hata çıkmasın diye ekledim

}

public class ClassroomStudent : Entity<int>
{
    public int ClassroomId { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; }
    public User User { get; set; }
}

/*
 1 - 1 - 1
 2 - 1 - 2
 */