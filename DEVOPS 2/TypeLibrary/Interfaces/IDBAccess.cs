﻿using System.Collections.Generic;
using TypeLibrary.Models;
using TypeLibrary.ViewModels;


namespace TypeLibrary.Interfaces
{
    public interface IDBAccess
    {
        bool AddEmployer(AddEmployer addemployer);
        bool AddJobPost(AddJobPost addjobpost);
        bool AddStudent(AddStudent addstudent);
        bool AddNewSkill(AddNewSkill addNewSkill);
        bool AddNewQual(AddNewQual addNewQual);
        bool AddNewIndustry(AddNewIndustry addNewIndustry);
        bool AddStudentSkill(AddStudentSkill addStudentSkill);
        bool AddStudentQual(AddStudentQual addStudentQual);
        UspCheckEmployerLogin CheckEmployerLogin(string employerEmail, string employerPassword);
        UspCheckStudentLogin CheckStudentLogin(int studentNo, string studentPassword);
        bool DeleteJobPost(DeleteJobPost deletejobpost);
        bool DeleteStudent(DeleteStudent deleteStudent);
        bool DeleteStudentSkill(DeleteStudentSkill deleteStudentSkill);
        bool DeleteStudentQual(DeleteStudentQual deleteStudentQual);
        bool DeleteEmployer(DeleteEmployer deleteEmployer);
        List<UspGetAllQualifications> GetAllQualifications();
        List<UspGetAllJobType> GetAllJobType();
        List<UspGetAllSkills> GetAllSkills();
        List<UspGetAllStatus> GetAllStatus();
        List<UspNumberOfStudents> GetNumberOfStudents();
        UspGetAllJobPostsByEmployer GetAllJobPostsByEmployer(int employerID);
        UspGetAllJobPostsByQualification GetAllJobPostsByQualification(int qualID);
        UspGetAllJobPostsBySkill GetAllJobPostsBySkill(int skillID);
        //UspGetAllJobPosts GetAllJobPosts(int employerID);
        UspGetAllJobPostsByType GetAllJobPostsByType(int typeID);
        UspGetAllStudentsByCity GetAllStudentsByCity(int cityID);
        UspGetAllStudentsByQualification GetAllStudentsByQualification(int qualID);
        UspGetAllStudentsBySkill GetAllStudentsBySkill(int skillID);
        bool UpdateEmployerProfile(UpdateEmployerProfile updateemployerprofile);
        bool UpdateStudentProfile(UpdateStudentProfile updatestudentprofile);
        ////List<UspGetAllJobPosts> GetAllJobPosts();
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

        //N_A------------------------------------------------------------------------------------------------------
        //------------------------------ADMIN STUFF---------------------------
        List<UspGetTotalEmployers> GetTotalEmployers();
        List<UspGetTotalStudents> GetTotalStudents();
        List<UspGetTotalJobPosts> GetTotalJobPosts();

        //------------------------------STUDENT SEARCH STUFF---------------------------
        List<UspGetAllEmployerNames> GetAllEmployerNames();
        List<UspGetMostRecentJobPosts> GetMostRecentJobPosts();
        List<UspGetJobTotalsByClosingDate> GetJobTotalsByClosingDate();
        List<UspGetJobTotalsByQualification> GetJobTotalsByQualification();
        List<UspGetJobTotalsBySkill> GetJobTotalsBySkill();
        List<UspGetAllJobPostBySearch> GetAllJobPostBySearch(int cityID, int qualID, int skillID);
        List<UspGetSelectedJobDetails> GetSelectedJobDetails();

        //------------------------------EMPLOYER SEARCH STUFF---------------------------
        List<UspGetMostRecentStudents> GetMostRecentStudents();
        UspGetAllStudentsBySearch GetAllStudentsBySearch(int cityID, int typeID, int employerID);
        List<UspGetStudentTotalsByQualification> GetStudentTotalsByQualification();
        List<UspGetStudentTotalsBySkill> GetStudentTotalsBySkill();
        List<UspGetStudentTotalsByDrivers> GetStudentTotalsByDrivers();
        List<UspGetSelectedStudentDetails> GetSelectedStudentDetails();

    }
}