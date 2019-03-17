using System;
using System.Collections.Generic;
using System.Linq;
using Data_Access_Layer.Models;
using Microsoft.EntityFrameworkCore;
using Presentation_layer_Web_API_.Models;

namespace Presentation_layer_Web_API_
{
    public class DbManager : IDisposable
    {
        private MonitoringContext monitoringContext;

        public DbManager()
        {
            monitoringContext = new MonitoringContext();
        }

        // Get all companies  
        public List<CompanyModel> GetAllCompanies()
        {
            List<Company> allCompanies = monitoringContext.Company.Include(x => x.Job).ToList();
            return Helper.FromDbCompanyListToCompanyModelList(allCompanies);
        }

        // Get a company by id  
        public CompanyModel GetCompanyById(int id)
        {
            Company dbCompany = monitoringContext.Company.Find(id);

            if (dbCompany == null)
            {
                CompanyModel nullModel = new CompanyModel();
                nullModel = null;
                return nullModel;
            }
            return Helper.FromDbCompanyToCompanyModel(dbCompany);
        }

        // Get all jobs   
        public HashSet<JobModel> GetAllJobs()
        {
            HashSet<Job> alljobs = monitoringContext.Job.ToHashSet();
            return Helper.FromDbJobHSetToJobModelHSet(alljobs);
        }

        // Get a job by id  
        public JobModel GetAJob(int id)
        {
            Job dbJob = monitoringContext.Job.Find(id);

            if (dbJob == null)
            {
                JobModel nullModel = new JobModel();
                nullModel = null;
                return nullModel;
            }
            return Helper.FromDbJobToJobModel(dbJob);
        }

        // Get all Github profiles
        public List<GithubProfileModel> GetAllGitHubProfiles()
        {
            List<GithubProfile> dbProfiles = monitoringContext.GithubProfile.ToList();
            return Helper.FromDbToModelGithubprofilesList(dbProfiles);
        }

        // Get a Github profile by id
        public GithubProfileModel GetAGithubProfile(int id)
        {
            GithubProfile dbProfile = monitoringContext.GithubProfile.Find(id);

            if (dbProfile == null)
            {
                GithubProfileModel nullModel = new GithubProfileModel();
                nullModel = null;
                return nullModel;
            }
            else
            {
                return Helper.FromDbToModelForGithubProfileModel(dbProfile);
            }
        }

        public void Dispose()
        {
            monitoringContext.Dispose();
        }
    }
}
