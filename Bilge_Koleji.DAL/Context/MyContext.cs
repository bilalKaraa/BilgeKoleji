using ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilge_Koleji.DAL.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("DbConnection")
        {
        }
        public DbSet<AttendanceStatus> AttendanceStatuses { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<ParentAndStudent> ParentAndStudents { get; set; }
        public DbSet<PreRegister> PreRegisters { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAndAttendanceStatus> StudentAndAntendanceStatuses { get; set; }
        public DbSet<SubLesson> SubLessons { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<WeeklyCourseSchedule> WeeklyCourseSchedules { get; set; }
        public DbSet<WeeklyCourseScheduleAndLesson> WeeklyCourseScheduleAndLessons { get; set; }


    }
}
