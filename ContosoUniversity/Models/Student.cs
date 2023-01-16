namespace ContosoUniversity.Models {
    public class Student {
        public int ID { get; set; }
        public string LastName { get; set; }
        public String FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
        
    }
}