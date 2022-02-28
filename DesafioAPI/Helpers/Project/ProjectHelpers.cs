using DesafioAPI.Requests.Projects;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAPI.Helpers.Project
{
    public class ProjectHelpers
    {
        public Project CriarProjetoDefault()
        {
            CreateProjectRequest createProjectRequest = new CreateProjectRequest();
            createProjectRequest.SetDefaultJsonBody();

            IRestResponse<dynamic> response = createProjectRequest.ExecuteRequest();

            JObject obs = JObject.Parse(response.Content);

            Project project = new Project();

            project.Id = (int)obs["project"]["id"];
            project.Name = (string)obs["project"]["name"];
            project.Description = (string)obs["project"]["description"];
            project.Enabled = (bool)obs["project"]["enabled"];


            return project;
        }

        public void AssociarSubProjeto(Project projeto, Project subprojeto)
        {
            AddSubProjectRequest addSubProjectRequest = new AddSubProjectRequest(projeto.Id);
            addSubProjectRequest.SetJsonBody(subprojeto.Name);

            IRestResponse<dynamic> response = addSubProjectRequest.ExecuteRequest();


        }

        public Project ObterProjetoPorId(int projectId)
        {
            GetAProjectRequest getAProjectRequest = new GetAProjectRequest(projectId.ToString());
            
            IRestResponse<dynamic> response = getAProjectRequest.ExecuteRequest();

            JObject obs = JObject.Parse(response.Content);

            Project project = new Project();

            project.Id = (int)obs["projects"][0]["id"];
            project.Name = (string)obs["projects"][0]["name"];
            project.Description = (string)obs["projects"][0]["description"];
            project.Enabled = (bool)obs["projects"][0]["enabled"];

            List<Project> subprojects = new List<Project>();

            foreach(var subproject in obs["projects"][0]["subProjects"])
            {
                Project proj = new Project();

                proj.Id = (int)subproject["id"];
                proj.Name = (string)subproject["name"];

                subprojects.Add(proj);
            }

            project.SubProjects = subprojects;

            return project;
        }


    }
}
