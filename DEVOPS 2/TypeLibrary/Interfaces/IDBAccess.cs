using System.Collections.Generic;
using TypeLibrary.Models;
using TypeLibrary.ViewModels;


namespace TypeLibrary.Interfaces
{
    public interface IDBAccess
    {
        bool AddEmployer(AddEmployer addemployer);
        bool AddJobPost(AddJobPost addjobpost);
        bool AddStudent(AddStudent addstudent);
        UspCheckEmployerLogin CheckEmployerLogin(string employerEmail, string employerPassword);
        UspCheckStudentLogin CheckStudentLogin(int studentNo, string studentPassword);
        bool DeleteJobPost(DeleteJobPost deletejobpost);
        bool DeleteStudent(DeleteStudent deleteStudent);
        bool DeleteEmployer(DeleteEmployer deleteEmployer);
        List<UspGetAllQualifications> GetAllQualifications();
        List<UspGetAllJobType> GetAllJobType();
        List<UspGetAllSkills> GetAllSkills();
        List<UspGetAllStatus> GetAllStatus();
        UspGetAllJobPostsByEmployer GetAllJobPostsByEmployer(int employerID);
        UspGetAllJobPostsByQualification GetAllJobPostsByQualification(int qualID);
        UspGetAllJobPostsBySkill GetAllJobPostsBySkill(int skillID);
        UspGetAllJobPostsByType GetAllJobPostsByType(int typeID);
        UspGetAllStudentsByCity GetAllStudentsByCity(int cityID);
        UspGetAllStudentsByQualification GetAllStudentsByQualification(int qualID);
        UspGetAllStudentsBySkill GetAllStudentsBySkill(int skillID);
        bool UpdateEmployerProfile(UpdateEmployerProfile updateemployerprofile);
        bool UpdateStudentProfile(UpdateStudentProfile updatestudentprofile);
        List<UspGetAllCountries> GetAllCountries();
        List<UspGetAllCities> GetAllCities();
        List<UspGetAllStudents> GetAllStudents();
        List<UspGetAllEmployers> GetAllEmployers();
        List<UspGetAllIndustries> GetAllIndustries();
        List<UspGetStudentProfile> GetStudentProfile(int studentNo);
        UspGetStudentProfile GetStudentProfile1(int studentNumber);
        
        UspGetEmployerProfile GetEmployerProfile1(string employerEmail);
        List<UspGetAdminLogin> GetAdminLogin();





        UspSearchStudents SearchStudents(int cityID, int typeID, int employerID);
        UspSearchJobs SearchJobs(int cityID, int qualID, int skillID);

    }
}