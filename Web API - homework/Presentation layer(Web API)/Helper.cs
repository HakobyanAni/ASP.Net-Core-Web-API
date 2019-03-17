using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data_Access_Layer.Models;
using Presentation_layer_Web_API_.Models;

namespace Presentation_layer_Web_API_
{
    public static class Helper
    {
        public static List<CompanyModel> FromDbCompanyListToCompanyModelList(List<Company> dbCompanies)
        {
            List<CompanyModel> allCompanies = new List<CompanyModel>();

            foreach (var dbCompany in dbCompanies)
            {
                CompanyModel companyTemp = FromDbCompanyToCompanyModel(dbCompany);
                allCompanies.Add(companyTemp);
            }
            return allCompanies;
        }

        public static CompanyModel FromDbCompanyToCompanyModel(Company dbCompany)
        {
            CompanyModel companyModel = new CompanyModel();
            companyModel.Name = dbCompany.Name;
            companyModel.About = dbCompany.About;
            companyModel.Industry = dbCompany.Industry;
            companyModel.NumberOfEmloyees = dbCompany.NumberOfEmployees;
            companyModel.DateOfFoundation = dbCompany.DateOfFoundation;
            companyModel.Website = dbCompany.Website;
            companyModel.Address = dbCompany.Address;
            companyModel.Facebook = dbCompany.Facebook;
            companyModel.Linkedin = dbCompany.Linkedin;
            companyModel.GoodlePlus = dbCompany.GooglePlus;
            companyModel.Twitter = dbCompany.Twitter;
            companyModel.Phone = dbCompany.Phone;
            companyModel.Views = dbCompany.Views;
            companyModel.Type = dbCompany.Type;
            return companyModel;
        }

        public static HashSet<JobModel> FromDbJobHSetToJobModelHSet(HashSet<Job> dbJob)
        {
            HashSet<JobModel> jobModels = new HashSet<JobModel>();
            foreach (var job in dbJob)
            {
                JobModel jobModel = FromDbJobToJobModel(job);
                jobModels.Add(jobModel);
            }
            return jobModels;
        }

        public static JobModel FromDbJobToJobModel(Job dbJob)
        {
            JobModel jobModel = new JobModel();
            jobModel.Title = dbJob.Title;
            jobModel.Email = dbJob.Email;
            jobModel.Deadline = dbJob.Deadline;
            jobModel.EmploymentTerm = dbJob.EmploymentTerm;
            jobModel.TimeType = dbJob.TimeType;
            jobModel.Category = dbJob.Category;
            jobModel.Location = dbJob.Location;
            jobModel.Description = dbJob.Description;
            jobModel.Responsibilities = dbJob.Responsibilities;
            jobModel.RequiredQualifications = dbJob.RequiredQualifications;
            jobModel.AdditionalInformation = dbJob.AdditionalInformation;
            jobModel.CompanyId = dbJob.CompanyId;
            return jobModel;
        }

        public static GithubProfileModel FromDbToModelForGithubProfileModel(GithubProfile dbGithubProfile)
        {
            GithubProfileModel profileModel = new GithubProfileModel();
            profileModel.UserName = dbGithubProfile.UserName;
            profileModel.Url = dbGithubProfile.Url;
            profileModel.Company = dbGithubProfile.Company;
            profileModel.Name = dbGithubProfile.Name;
            profileModel.Bio = dbGithubProfile.Bio;
            profileModel.Location = dbGithubProfile.Location;
            profileModel.Email = dbGithubProfile.Email;
            profileModel.BlogOrWebsite = dbGithubProfile.BlogOrWebsite;
            profileModel.StarsCount = dbGithubProfile.StarsCount;
            profileModel.LastUpdate = dbGithubProfile.LastUpdate;
            return profileModel;
        }

        public static List<GithubProfileModel> FromDbToModelGithubprofilesList(List<GithubProfile> dbProfile)
        {
            List<GithubProfileModel> allProfiles = new List<GithubProfileModel>();
            foreach (var profile in dbProfile)
            {
                GithubProfileModel temp = FromDbToModelForGithubProfileModel(profile);
                allProfiles.Add(temp);
            }
            return allProfiles;
        }
    }
}
