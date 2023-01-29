class IntersectionOfArrays
{
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            List<int> list1 = nums1.ToList();
            List<int> list2 = nums2.ToList();
            List<int> values = new List<int>();
            foreach (var item in list1)
            {
                if (list2.Contains(item))
                {
                    if (!values.Contains(item))
                    {
                        values.Add(item);
                    }
                }
            }
            return values.ToArray();
        }
}