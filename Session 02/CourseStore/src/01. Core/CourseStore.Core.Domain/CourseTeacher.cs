﻿namespace CourseStore.Core.Domain
{
    public class CourseTeacher
    {
        public int CourseId { get; set; }
        public int TeacherId { get; set; }
        public int SortOrder { get; set; }
        public Teacher  Teacher{ get; set; }
        public Course  Course{ get; set; }
    }
}
