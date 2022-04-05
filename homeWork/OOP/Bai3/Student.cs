namespace Bai3
{
    partial class Program
    {
        class Student
        {
            public string id{ get; set; }
            public string name { get; set; }
            public int mark { get; set; }
            public int scholaship
            {
                set
                {
                    if (mark > 8)
                    {
                        scholaship = 500;
                    }
                    else if (mark >= 7 && mark <= 8)
                    {
                        scholaship = 300;
                    }
                    else scholaship = 0;
                }
                get
                {
                    return scholaship;
                }
            }

            public Student(string id, string name, int mark)
            {
                this.id = id;
                this.name = name;
                this.mark = mark;
            }

            public Student()
            {
            }

            public Student(string id)
            {
                this.id = id;
            }
        }
    }
}
