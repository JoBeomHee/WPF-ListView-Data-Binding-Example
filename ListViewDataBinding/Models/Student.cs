using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListViewDataBinding
{
    public class StudentList : ObservableCollection<Student>
    {
        /// <summary>
        /// 생성자
        /// </summary>
        public StudentList()
        {
            Add(new Student() { Name = "범범조조", Age = 28, PhoneNumber = "010-2345-2222" });
            Add(new Student() { Name = "안정환", Age = 20, PhoneNumber = "010-4345-2222" });
            Add(new Student() { Name = "아이유", Age = 38, PhoneNumber = "010-5345-2672" });
            Add(new Student() { Name = "정형돈", Age = 21, PhoneNumber = "010-3345-2752" });
            Add(new Student() { Name = "유재석", Age = 74, PhoneNumber = "010-4345-2752" });
            Add(new Student() { Name = "박명수", Age = 54, PhoneNumber = "010-5345-2752" });
            Add(new Student() { Name = "하하", Age = 47, PhoneNumber = "010-8345-2752" });
            Add(new Student() { Name = "광희", Age = 21, PhoneNumber = "010-6745-2752" });
            Add(new Student() { Name = "조세호", Age = 31, PhoneNumber = "010-6345-2752" });
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
    }
}
