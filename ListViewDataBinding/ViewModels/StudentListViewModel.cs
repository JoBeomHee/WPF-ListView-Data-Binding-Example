using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewDataBinding.ViewModels
{
    public class StudentListViewModel
    {
        private readonly StudentList items;

        public StudentListViewModel()
        {
            this.items = new StudentList();
        }

        public StudentList Items
        {
            get { return this.items; }
        }
    }
}
