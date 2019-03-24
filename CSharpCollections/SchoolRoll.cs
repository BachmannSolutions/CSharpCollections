using System.Collections.Generic;

namespace CSharpCollections
{
    class SchoolRoll
    {
        private HashSet<Student> _students = new HashSet<Student>();

        public IEnumerable<Student> Students { get { return _students; } }

        public void AddStudents( IEnumerable<Student> students )
        {
            _students.UnionWith( students );
        }
    }
}
