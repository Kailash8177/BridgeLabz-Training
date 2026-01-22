using System;
using System.Collections.Generic;
using System.Text;

namespace rank_sheet_generator
{
    public class MergeSortUtility
    {
        public static List<Student> MergeSort(List<Student> students)
        {
            if (students.Count <= 1)
                return students;

            int mid = students.Count / 2;

            var left = MergeSort(students.GetRange(0, mid));
            var right = MergeSort(students.GetRange(mid, students.Count - mid));

            return Merge(left, right);
        }

        private static List<Student> Merge(List<Student> left, List<Student> right)
        {
            List<Student> result = new List<Student>();
            int i = 0, j = 0;

            while (i < left.Count && j < right.Count)
            {
                // Stable sorting
                if (left[i].Marks <= right[j].Marks)
                    result.Add(left[i++]);
                else
                    result.Add(right[j++]);
            }

            while (i < left.Count) result.Add(left[i++]);
            while (j < right.Count) result.Add(right[j++]);

            return result;
        }
    }
}