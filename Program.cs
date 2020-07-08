using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuTask
{
    public class Track
    {
        public Track(int trackId, string mangerName, string trackName, int duration, Student[] stu)
        {
            this.trackId = trackId;
            this.mangerName = mangerName;
            this.trackName = trackName;
            this.duration = duration;
            this.stu = stu;
        }

        public Track()
        {
        }

        public int trackId { set; get; }
        public string mangerName { set; get; }
        public string trackName { set; get; }
        public int duration { set; get; }

        public Student[] stu { get; set; }



        public override string ToString()
        {
            string txt = $"\n=-> track id : {trackId} - Manger Name : {mangerName} - Track Name : {trackName} - Duration : {duration} \n ";
            if (stu == null) { }
            else
            {
                for (int i = 0; i < stu.Length; i++)
                {
                    txt += "\n    -->" + stu[i].ToString() + "\n";
                }
            }
            return txt;
        }
        public string ToString_trackWithStu()
        {
            string txt = $"\ntrack id : {trackId} - Manger Name : {mangerName} - Track Name : {trackName} - Duration : {duration} \n ";
            if (stu == null) { }
            else
            {
                for (int i = 0; i < stu.Length; i++)
                {
                    txt += "\n   -->" + stu[i].To_string_t2s() + "\n";
                }
            }
            return txt;
        
         } 
        ~Track()
        {
            Console.WriteLine("Track Ended");
        }

    }
    public class Student
    {
        public Student(int studentId, string studentName, int age, int mobNum, Subject[] subjects)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.age = age;
            this.mobNum = mobNum;
            this.subjects = subjects;
        }

        public int studentId { get; set; }
        public string studentName { get; set; }
        public int age { get; set; }
        public int mobNum { get; set; }

        public Subject[] subjects { get; set; }

        public override string ToString()
        {
            string txt= $"Student id : {studentId} - Student name : {studentName} - Student age : {age} - Student Mobile Number : {mobNum} \n ";
            if (subjects == null) { }
            else
            {
                for (int i = 0; i < subjects.Length; i++)
                {
                    txt += "\n         ->>" + subjects[i].ToString();
                }
            }

            return txt;

        }


        public string To_string_t2s()
        {
            string txt = $"Student id : {studentId} - Student name : {studentName} - Student age : {age} - Student Mobile Number : {mobNum} ";
            return txt;

        }

        ~Student()
        {
            Console.WriteLine("Student Ended");
        }


    }
    public class Subject
    {
        public Subject(int subId, string subName, int subDuration)
        {
            this.subId = subId;
            this.subName = subName;
            this.subDuration = subDuration;
        }

        public int subId { get; set; }
        public string subName { get; set; }
        public int subDuration { get; set; }

        public override string ToString()
        {
            return $"Subject ID : {subId} - Subject Name : {subName} - Subject Duration : {subDuration}";
        }

        ~Subject() {
            Console.WriteLine("End Of Subject");
        }

    }
    public static class DynamicArr
    {
        public static Subject[] addSubject(Subject[] array, Subject newValue)
        {
            int newLength = array.Length + 1;

            Subject[] result = new Subject[newLength];

            for (int i = 0; i < array.Length; i++)
                result[i] = array[i];

            result[newLength - 1] = newValue;

            return result;
        }
        public static Student[] addStudent(Student[] array, Student newValue)
        {
            int newLength = array.Length + 1;

            Student[] result = new Student[newLength];

            for (int i = 0; i < array.Length; i++)
                result[i] = array[i];

            result[newLength - 1] = newValue;

            return result;
        }
        public static string[] Add(string[] array, string newValue)
        {
            int newLength = array.Length + 1;

            string[] result = new string[newLength];

            for (int i = 0; i < array.Length; i++)
                result[i] = array[i];

            result[newLength - 1] = newValue;

            return result;
        }

        public static string[] RemoveAt(string[] array, int index)
        {
            int newLength = array.Length - 1;

            if (newLength < 1)
            {
                return array;
            }

            //this would also be a good time to check for "index out of bounds" and throw an exception or handle some other way

            string[] result = new string[newLength];
            int newCounter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == index)//it is assumed at this point i will match index once only
                {
                    continue;
                }
                result[newCounter] = array[i];
                newCounter++;
            }

            return result;
        }
        public static void print(string[] arr, string[] newArr, int checker)
        {
            if (checker % 2 == 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine($"{arr[i]} +  ");
                }
            }
            else
            {
                for (int i = 0; i < newArr.Length; i++)
                {
                    Console.WriteLine($"{ newArr[i]} +    ");

                }
            }


        }
        public static void printOne(Subject[] arr) {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].subName+"\n");
            }
        }
    }

    class Program
    {
        
        
        
        static void Main(string[] args)
        {
            Student[] st_arr = new Student[0];
            Student[] st_newArr = new Student[0];
            Track track=new Track(1, "Mohamed", "c#", 30, st_arr); ;
      //      Track newTrack;

            Subject[] sb_arr = new Subject[0];
            Subject[] sb_newArr = new Subject[0];



            int st_checker = 2;
            int sb_checker = 2;

            int selected;

            do
            {
                Console.WriteLine("Menu ----> \n\n" +
               "1-Add New Data\n" +
               "2-Display\n" +
               "3-Edit\n" +
               "4-Delete\n" +
               "5-Exit\n" +
               "\n//////////////////////////////////////////////////////////////////////////");


                selected = int.Parse(Console.ReadLine());
                switch (selected)
                {
                    case 1:
                        Console.WriteLine("New Menu ---->\n" +
                            "1 - Creat New Student\n" +
                            "2 - Add Subject To Student\n");
                        selected = int.Parse(Console.ReadLine());
                        switch (selected)
                        {
                            case 1:
                                Console.WriteLine("Enter ID");
                                int student_id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Name");
                                string student_name = Console.ReadLine();
                                Console.WriteLine("Enter Age");
                                int student_age = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Mobile Number");
                                int student_mob = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter How Much Subjects");
                                int subj = int.Parse(Console.ReadLine());
                                for (int i = 0; i < subj; i++)
                                {
                                    int subject_id = i + 1;
                                    Console.WriteLine($"Enter Name Subject Number : {i + 1}\n");
                                    string subject_name = Console.ReadLine();
                                    Console.WriteLine($"Enter Duration Subject Of {subject_name}\n");
                                    int subject_duration = int.Parse(Console.ReadLine());
                                    if (sb_checker%2== 0) {
                                        sb_newArr = DynamicArr.addSubject(sb_arr, new Subject(subject_id, subject_name, subject_duration));
                                        sb_checker++;
                                    }
                                    else {
                                        sb_arr = DynamicArr.addSubject(sb_newArr, new Subject(subject_id, subject_name, subject_duration));
                                        sb_checker++;
                                    }
                                }

                                if (st_checker % 2 == 0)
                                {
                                    if (sb_checker % 2 == 0) {
                                        st_arr = DynamicArr.addStudent(st_newArr, new Student(student_id, student_name, student_age, student_mob, sb_arr));
                                        sb_arr = new Subject[0];
                                        st_checker++;
                                    } else {
                                        st_arr = DynamicArr.addStudent(st_newArr, new Student(student_id, student_name, student_age, student_mob, sb_newArr));
                                        sb_newArr = new Subject[0];
                                        st_checker++;
                                    }
                                }
                                else
                                {
                                    if (sb_checker % 2 == 0)
                                    {
                                        st_newArr = DynamicArr.addStudent(st_arr, new Student(student_id, student_name, student_age, student_mob, sb_arr));
                                        sb_arr = new Subject[0];
                                        st_checker++;
                                    }
                                    else
                                    {
                                        st_newArr = DynamicArr.addStudent(st_arr, new Student(student_id, student_name, student_age, student_mob, sb_newArr));
                                        sb_newArr = new Subject[0];
                                        st_checker++;
                                    }
                                }
                                break;
                            case 2:
                                Console.WriteLine("Enter Student ID");
                                int s_id = int.Parse(Console.ReadLine());
                                Console.WriteLine($"Enter Name Of New Subject");
                                string sub_name = Console.ReadLine();
                                Console.WriteLine($"Enter Duration Of {sub_name} ");
                                int sub_du = int.Parse(Console.ReadLine());
                                if (st_checker % 2 == 0)
                                {

                                    int control = 0;
                                    for (int i = 0; i < st_newArr.Length; i++)
                                    {
                                        if (s_id == st_newArr[i].studentId)
                                        {
                                            sb_newArr = st_newArr[i].subjects;
                                            DynamicArr.printOne(sb_newArr);
                                            control = i;
                                        }
                                        else { Console.WriteLine("No One here"); }
                                    }
                                    sb_arr = DynamicArr.addSubject(sb_newArr, new Subject(2, sub_name, sub_du));
                                    st_newArr[control].subjects = sb_arr;
                                    sb_arr = new Subject[0];
                                    sb_newArr = new Subject[0];
                                    sb_checker++;
                                }
                                else
                                {
                                    int control = 0;
                                    for (int i = 0; i < st_arr.Length; i++)
                                    {
                                        if (s_id == st_arr[i].studentId)
                                        {
                                            sb_arr = st_arr[i].subjects;
                                            DynamicArr.printOne(sb_arr);
                                            control = i;

                                        }
                                        else { Console.WriteLine("No One here"); }
                                    }
                                    sb_newArr = DynamicArr.addSubject(sb_arr, new Subject(2, sub_name, sub_du));
                                    st_arr[control].subjects = sb_newArr;
                                    sb_newArr = new Subject[0];
                                    sb_arr = new Subject[0];
                                    sb_checker++;
                                }
                                break;
                        }

                        break;
                    case 2:
                        Console.WriteLine("\nDisplay Menu ----->\n" +
                            "1 - Display ALL\n" +
                            "2 - Display Tracks With Students\n" +
                            "3 - Display Students With Subjects\n" +
                            "/////////////////////////////\n");
                        selected = int.Parse(Console.ReadLine());
                        switch (selected) {
                            case 1:
                                if (st_checker % 2 == 1) {
                                    //track = new Track(1, "Mohamed", "c#", 30, st_arr);
                                    track.stu = st_arr;
                                    Console.WriteLine(track.ToString());
                                }
                                else{
                                    // track = new Track(1, "Mohamed", "c#", 30, st_newArr);
                                    track.stu = st_newArr;
                                    Console.WriteLine(track.ToString());
                                }
                                break;
                            case 2:
                                if (st_checker % 2 == 1)
                                {
                                    // track = new Track(1, "Mohamed", "c#", 30, st_arr);
                                    track.stu = st_arr;
                                    Console.WriteLine(track.ToString_trackWithStu());
                                }
                                else
                                {
                                    //track = new Track(1, "Mohamed", "c#", 30, st_newArr);
                                    track.stu = st_newArr;
                                    Console.WriteLine(track.ToString_trackWithStu());
                                }
                                break;
                            case 3:
                                if (st_checker%2==1) {
                                    for(int i = 0; i < st_arr.Length; i++)
                                    {
                                        Console.WriteLine(st_arr[i].ToString());
                                    }
                                }
                                else
                                {
                                    for (int i = 0; i < st_newArr.Length; i++)
                                    {
                                        Console.WriteLine(st_newArr[i].ToString());
                                    }
                                }
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Edit Menu ----->\n" +
                            "1-Edit Track\n" +
                            "2-Edit Student\n" +
                            "3-Edit Subject\n" +
                            "//////////////////////////////////////////////// ");
                        selected = int.Parse(Console.ReadLine());
                        switch (selected)
                        {
                            case 1:
                                Console.WriteLine("Edit Track Menu ----->\n" +
                            "1-Edit Track ID\n" +
                            "2-Edit Track MangerName\n" +
                            "3-Edit Track Name\n" +
                            "4-Edit Track Duration\n" +
                            "//////////////////////////////////////////////// ");
                                selected = int.Parse(Console.ReadLine());
                                switch (selected) {
                                    case 1:
                                        Console.WriteLine("Enter New ID");
                                        int NewTrackId = int.Parse(Console.ReadLine());
                                        track.trackId = NewTrackId;
                                        break;
                                    case 2:
                                        Console.WriteLine("Enter New Manger Name");
                                        string newMangerName = Console.ReadLine();
                                        track.mangerName = newMangerName;
                                        break;
                                    case 3:
                                        Console.WriteLine("Enter New Track Name");
                                        string newTrackName = Console.ReadLine();
                                        track.trackName = newTrackName;
                                        break;
                                    case 4:
                                        Console.WriteLine("Enter New Duration");
                                        int NewDuration = int.Parse(Console.ReadLine());
                                        track.duration = NewDuration;
                                        break;
                                    default:
                                        Console.WriteLine("Please Enter Correct Choice");
                                        break;
                                }
                                break;
                            case 2:
                                Console.WriteLine("Edit Student Menu ----->\n" +
                            "1-Edit Student ID\n" +
                            "2-Edit Student Name\n" +
                            "3-Edit Student Age\n" +
                            "4-Edit Student Mobile\n" +
                            "//////////////////////////////////////////////// ");
                                selected = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Student ID to Edit Infromation");
                                int edited = int.Parse(Console.ReadLine());
                                switch (selected) {
                                    case 1:
                                        Console.WriteLine("Enter New Student ID");
                                        int new_StudentId = int.Parse(Console.ReadLine());
                                        if (st_checker % 2 == 1)
                                        {
                                            
                                            for (int i = 0; i < st_arr.Length; i++)
                                            {
                                                if (st_arr[i].studentId == edited)
                                                {
                                                    st_arr[i].studentId = new_StudentId;
                                                }
                                            }
                                        }
                                        else {
                                            for (int i = 0; i < st_newArr.Length; i++)
                                            {
                                                if (st_newArr[i].studentId == edited)
                                                {
                                                    st_newArr[i].studentId = new_StudentId;
                                                }
                                            }
                                        }
                                            
                                        break;
                                    case 2:
                                        Console.WriteLine("Enter New Student Name");
                                        string new_StudentName = Console.ReadLine();
                                        if (st_checker % 2 == 1)
                                        {

                                            for (int i = 0; i < st_arr.Length; i++)
                                            {
                                                if (st_arr[i].studentId == edited)
                                                {
                                                    st_arr[i].studentName = new_StudentName;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            for (int i = 0; i < st_newArr.Length; i++)
                                            {
                                                if (st_newArr[i].studentId == edited)
                                                {
                                                    st_newArr[i].studentName= new_StudentName;
                                                }
                                            }
                                        }

                                        break;
                                    case 3:
                                        Console.WriteLine("Enter New Student Age");
                                        int new_StudentAge = int.Parse(Console.ReadLine());
                                        if (st_checker % 2 == 1)
                                        {

                                            for (int i = 0; i < st_arr.Length; i++)
                                            {
                                                if (st_arr[i].studentId == edited)
                                                {
                                                    st_arr[i].age = new_StudentAge;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            for (int i = 0; i < st_newArr.Length; i++)
                                            {
                                                if (st_newArr[i].studentId == edited)
                                                {
                                                    st_newArr[i].age = new_StudentAge;
                                                }
                                            }
                                        }
                                        break;
                                    case 4:
                                        Console.WriteLine("Enter New Student Mobile Number");
                                        int new_StudentMob = int.Parse(Console.ReadLine());
                                        if (st_checker % 2 == 1)
                                        {

                                            for (int i = 0; i < st_arr.Length; i++)
                                            {
                                                if (st_arr[i].studentId == edited)
                                                {
                                                    st_arr[i].mobNum = new_StudentMob  ;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            for (int i = 0; i < st_newArr.Length; i++)
                                            {
                                                if (st_newArr[i].studentId == edited)
                                                {
                                                    st_newArr[i].mobNum = new_StudentMob;
                                                }
                                            }
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Please Enter Correct Choice");
                                        break;
                                }
                                

                                break;
                            case 3:
                                break;
                        }
                        break;
                    case 4:
                        break;

                }

            } while (selected != 5);

            Console.Read();
        }
    }
}
