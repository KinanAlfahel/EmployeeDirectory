using System;

namespace EmployeeDirectory
{
    public class Robot
    {
        // private string name;

        private int height;

        public int Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(nameof(Height));
                }
                else
                {
                    height = value;
                }
            }
        }


        public string Name { get; set; }

        public Robot()
        {

        }

        public Robot(int height, string name)
        {
            Height = height;
            Name = name;
        }


        //public string GetName()
        //{
        //    return name;
        //}

        //public void SetName(string newName)
        //{
        //    //Validate
        //    name = newName;
        //}
    }
}