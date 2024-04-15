using System.Collections.Generic;
using System.Linq;

namespace DevCard.Models
{
    public class ProjectData
    {
        public static List<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project(1, "پروژه اول", "توضیحات پروژه اول", "project-1.jpg", "کلاینت اول"),
                new Project(2, "پروژه دوم", "توضیحات پروژه دوم", "project-2.jpg", "کلاینت دوم"),
                new Project(3, "پروژه سوم", "توضیحات پروژه سوم", "project-3.jpg", "کلاینت اوسومل"),
                new Project(4, "پروژه چهارم", "توضیحات پروژه چهارم", "project-4.jpg", "کلاینت چهارم")
            };
        }

        public static Project GetProjectById(long id)
        {
            return GetProjects().FirstOrDefault(x => x.Id == id);
        }
    }
}
