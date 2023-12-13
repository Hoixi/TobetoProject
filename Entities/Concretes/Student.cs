﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

public class Student : Entity<int>
{
    public int UserId {  get; set; }
    public int ClassroomId {  get; set; }
    public User User { get; set; }
    public Classroom Classroom { get; set; }
}
