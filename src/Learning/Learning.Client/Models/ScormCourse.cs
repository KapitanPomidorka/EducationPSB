
namespace Learning.Client.Models
{
    public class ScormCourse // пример реализации SCORM. Если успеем, то будет большим плюсом его добавление
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Version { get; set; } = "SCORM 1.2";

        public string PackagePath { get; set; }
        public string EntryPoint { get; set; } = "index.html";
        public long FileSize { get; set; }
        public Guid GroupId { get; set; }
        public Groups Group { get; set; }

        public List<ScormAttempt> Attempts { get; set; } = new();
    }

    public class ScormAttempt
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Students Student { get; set; }

        public int ScormCourseId { get; set; }
        public ScormCourse ScormCourse { get; set; }


        public string LessonStatus { get; set; } // "passed", "failed", "completed"
        public string CompletionStatus { get; set; }
        public double Score { get; set; }
        public TimeSpan TotalTime { get; set; }
        public string SuspendData { get; set; } 
        public DateTime LastUpdated { get; set; }
    }
}
