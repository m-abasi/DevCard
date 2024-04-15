using System.Collections;
using System.Collections.Generic;
using DevCard.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard.ViewComponents
{
    public class ProjectsViewComponent:ViewComponent

    {
    public IViewComponentResult Invoke()
    {
        var projects = ProjectData.GetProjects();

        return View("_Projects",projects);
    }


    }
}
